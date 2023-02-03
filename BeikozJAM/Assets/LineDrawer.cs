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
    private Text distanceText;

    private float distance;

    private void Start()
    {
        lineRend = GetComponent<LineRenderer>();
        lineRend.positionCount = 2;
    }


    private void Update()
    {

        startMousePos = GameObject.Find("character").transform.position;



        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lineRend.SetPosition(0, new Vector3(startMousePos.x, startMousePos.y, 0f));
        lineRend.SetPosition(1, new Vector3(mousePos.x, mousePos.y, 0f));
        distance = (mousePos - startMousePos).magnitude;

    }
}
