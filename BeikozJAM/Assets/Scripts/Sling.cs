using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sling : MonoBehaviour
{
    private bool isPressed;

    private float releaseDelay;

    private Rigidbody2D rb;
    private SpringJoint2D sj;

    public GameObject sling;
    private GameObject slingCircle;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sj = GetComponent<SpringJoint2D>();

        releaseDelay = 1 / (sj.frequency * 4);
    }
    private void Start()
    {
        slingCircle = Instantiate(sling);
        slingCircle.transform.position = transform.position;
    }
    private void DragBall()
    {

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rb.position = mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            DragBall();
        }
    }

    private void OnMouseDown()
    {
            isPressed = true;
            rb.isKinematic = true;
            StopCoroutine(Release());
            sj.enabled = true;
    }
    private void OnMouseUp()
    {
            isPressed = false;
            rb.isKinematic = false;
            StartCoroutine(Release());
            Destroy(slingCircle);
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseDelay);
        sj.enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = new Vector2(0,0);
        slingCircle = Instantiate(sling);
        slingCircle.transform.position = transform.position;
        StopCoroutine(Release());
        sj.enabled = true;
    }

}
