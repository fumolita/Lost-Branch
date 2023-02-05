using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip rainSound, jumpSound, hitSound, crackSound;
    static AudioSource audioSrc;
    void Start()
    {
        rainSound = Resources.Load<AudioClip>("rain");
        jumpSound = Resources.Load<AudioClip>("jump");
        hitSound = Resources.Load<AudioClip>("hit");
        crackSound = Resources.Load<AudioClip>("crack");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {

            case "rain" :
                audioSrc.PlayOneShot(rainSound);
                break;
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "hit":
                audioSrc.PlayOneShot(hitSound);
                break;
            case "crack":
                audioSrc.PlayOneShot(crackSound);
                break;

        }
    }

}
