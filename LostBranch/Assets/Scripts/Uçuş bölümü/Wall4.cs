using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall4 : MonoBehaviour
{
    public void Death()
    {
        SceneManager.LoadScene(11);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Death();
        }
    }
}
