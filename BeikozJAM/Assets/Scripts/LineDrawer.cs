using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineDrawer : MonoBehaviour
{
    private LineRenderer lineRend;
    private Vector2 mousePos;
    private Vector2 startMousePos;

    [SerializeField]


    private void Start()
    {
        lineRend = GetComponent<LineRenderer>();
        lineRend.positionCount = 2;
        lineRend.material.SetColor("_Color", Color.gray);
    }


    private void Update()
    {

        startMousePos = GameObject.Find("Square (1)").transform.position;
        Vector3 oppositeDirection = (Camera.main.ScreenToWorldPoint(GameObject.Find("Square (1)").transform.position) - Camera.main.ScreenToWorldPoint(Input.mousePosition));


        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lineRend.SetPosition(0, new Vector3(startMousePos.x, startMousePos.y, 0f));
        lineRend.SetPosition(0,oppositeDirection);

    }
}
