using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall3 : MonoBehaviour
{
    public void Death()
    {
        SceneManager.LoadScene(7);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Death();
        }
    }
}
