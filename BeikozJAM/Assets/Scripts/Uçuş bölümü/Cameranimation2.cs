using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cameranimation2 : MonoBehaviour
{

    private int click;

    public void Skip()
    {
        SceneManager.LoadScene(4);
    }

    void Update()
    {
        while (Camera.main.transform.position.y > new Vector3(0, -65f, 0).y && Camera.main.transform.position.y <= new Vector3(0, -15f, 0).y)
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

        while (Camera.main.transform.position.y == new Vector3(0, -65f, 0).y)
        {
            if (Input.anyKeyDown)
            {
                Skip();
                break;
            }
            else
            {
                break;
            }

        }

    }
}
