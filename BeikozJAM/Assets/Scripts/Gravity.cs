using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    float timeLeft = 2.0f;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Physics.gravity = new Vector3(0, -1.0F, 0);
        }


    }
}
