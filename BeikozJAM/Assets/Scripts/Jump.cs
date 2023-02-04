using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    private Vector3 mouseStart;
    private Vector3 mouseEnd;
    public Rigidbody2D rb;
    public bool onCollision;

    private void OnMouseDown()
    {
        while (onCollision == true)
        {
            //rb = GetComponent<Rigidbody2D>();

            mouseStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            break;
        }
    }

    private void OnMouseUp()
    {
        while (onCollision == true)
        {

            mouseEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 distance = (mouseEnd - mouseStart) * 5;
            rb.velocity = new Vector2(-distance.x, -distance.y);
            break;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = new Vector2(0, 0);
        onCollision = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        onCollision = false;
    }


}
