using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameranimation : MonoBehaviour
{

    void Update()
    {
        while (Camera.main.transform.position.y > new Vector3(0, -50f, 0).y)
        {
            if (Input.anyKeyDown)
            {
                Camera.main.transform.Translate(0, -10f, 0);
                break;
            }
            else
            {
                break;
            }
        }



    }
}
