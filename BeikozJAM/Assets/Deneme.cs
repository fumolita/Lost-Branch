using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    private bool isPressed;
    private Vector3 mouseStart;
    private Vector3 mouseEnd;
    public Rigidbody2D rb;

    private void Update()
    {
        if (isPressed)
        {
            Debug.DrawLine(mouseStart, mouseEnd, Color.red);
        }
    }
    private void OnMouseDown()
    {
        //rb = GetComponent<Rigidbody2D>();
        isPressed = true;
        mouseStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        isPressed = false;
        mouseEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 distance = (mouseEnd - mouseStart) * 5;
        rb.velocity = new Vector2(-distance.x, -distance.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = new Vector2(0, 0);
    }


}
