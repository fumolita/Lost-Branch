using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadesarkı : MonoBehaviour
{
    public AudioSource currentMusic;
    public AudioSource nextMusic;
    public float fadeSpeed = 1.0f;

    private void Start()
    {
        currentMusic.Play();
    }

    public void FadeToNextMusic()
    {
        StartCoroutine(FadeOutAndIn());
    }

    IEnumerator FadeOutAndIn()
    {
        float startVolume = currentMusic.volume;

        while (currentMusic.volume > 0)
        {
            currentMusic.volume -= startVolume * Time.deltaTime * fadeSpeed;
            yield return null;
        }

        currentMusic.Stop();
        nextMusic.Play();

        while (nextMusic.volume < startVolume)
        {
            nextMusic.volume += startVolume * Time.deltaTime * fadeSpeed;
            yield return null;
        }

        currentMusic = nextMusic;
    }
}


