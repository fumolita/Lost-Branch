using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameranimation : MonoBehaviour
{
    float timeLeft = 2.0f;

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Camera.main.transform.Translate(0, -10f, 0);
            timeLeft = 2.0f;
        }
    }
}
