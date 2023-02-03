using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{

    public float speed = 50;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        
        Vector2 pos = transform.position;

        pos.x += h * speed * Time.deltaTime;
        

        transform.position = pos;
    }


}
