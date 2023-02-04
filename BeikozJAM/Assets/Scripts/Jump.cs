using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{


    private Vector2 mouseStart;
    private Vector2 mouseEnd;
    public Rigidbody2D rb;
    public bool onCollision;
    public GameObject PointPrefab;
    public bool isPressed;
    public Vector3 ArrowOrigin;
    public Vector3 ArrowTarget;

    public LineRenderer lineRenderer;

    private void Start()
    {
        gameObject.GetComponent<LineRenderer>().positionCount = 2;
        gameObject.GetComponent<LineRenderer>().material.SetColor("_Color", Color.red);
        ; lineRenderer.enabled = false;
        lineRenderer = this.GetComponent<LineRenderer>();
        lineRenderer.widthCurve = new AnimationCurve(
            new Keyframe(0, 0.4f)
            , new Keyframe(0.999f - 0.1f, 0.1f)  // neck of arrow
            , new Keyframe(1 - 0.1f, 0.1f)  // max width of arrow head
            , new Keyframe(0.1f,0f));  // tip of arrow
        lineRenderer.SetPositions(new Vector3[] {
              ArrowOrigin
              , Vector3.Lerp(ArrowOrigin, ArrowTarget, 0.999f - 0.8f)
              , Vector3.Lerp(ArrowOrigin, ArrowTarget, 1 - 0.8f)
              , ArrowTarget });
    }
    private void OnMouseDown()
    {
        while (onCollision == true)
        {
            //rb = GetComponent<Rigidbody2D>();

            mouseStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isPressed = true;
            lineRenderer.enabled = true;
            lineRenderer.SetPosition(0, Camera.main.ScreenToWorldPoint(Input.mousePosition));
            break;
        }
        
    }

    private void OnMouseUp()
    {
        while (onCollision == true)
        {

            mouseEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 distance = (mouseEnd - mouseStart) * 5;
            rb.velocity = new Vector2(-distance.x, -distance.y);
            isPressed = false;
            lineRenderer.enabled = false;
            break;
        }
    }
    private void Update()
    {
        if (isPressed)
        {
            lineRenderer.SetPosition(0, -((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseStart)*2);
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