using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BranchMovement : MonoBehaviour
{

    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;


    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent <Rigidbody2D>();

        speed = 7;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(myBody.velocity.x, speed);
    }

    public void Death()
    {
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Death();
        }
    }

}
