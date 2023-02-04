using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.CompareTag("Branch"))
        {
            Destroy(collision.gameObject);
        }

        else if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Camera.main.transform.Translate(0, -10, 0);
        }
        
    }



}
