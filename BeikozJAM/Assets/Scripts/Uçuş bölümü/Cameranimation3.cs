using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cameranimation3 : MonoBehaviour
{

    private int click;

    public void Skip()
    {
        SceneManager.LoadScene(3);
    }

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

        

        while (Camera.main.transform.position.y == new Vector3(0, -50f, 0).y)
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
