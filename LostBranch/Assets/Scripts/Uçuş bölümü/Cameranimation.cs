using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cameranimation : MonoBehaviour
{
    public Animator transitionAnim;

    public void Skip()
    {
        StartCoroutine(Load());
    }

    IEnumerator Load()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.99f);
        SceneManager.LoadScene(10);
    }

    IEnumerator _Camera()
    {

        yield return new WaitForSeconds(0.5f);
        Camera.main.transform.Translate(0, -10f, 0);
        StopCoroutine("_Camera");
    }

    void Update()
    {
        while (Camera.main.transform.position.y > new Vector3(0, -190f, 0).y)
        {
            if (Input.anyKeyDown)
            {
                Camera.main.transform.Translate(0, -10f, 0);
                StartCoroutine(_Camera());
                break;
            }
            else
            {
                break;
            }
        }

        while (Camera.main.transform.position.y == new Vector3(0, -190f, 0).y)
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
