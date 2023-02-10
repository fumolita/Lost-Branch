using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transitionAnim;

    public void PlayGame()
    {
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.99f);
        SceneManager.LoadScene(1);
    }

}
