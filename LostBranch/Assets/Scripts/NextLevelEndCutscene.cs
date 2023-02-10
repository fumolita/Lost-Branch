using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelEndCutscene : MonoBehaviour
{
    public Animator transitionAnim;

    IEnumerator Load()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.10f);
        SceneManager.LoadScene(6);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(Load());
        }
    }
}
