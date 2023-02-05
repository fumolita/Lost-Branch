using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos1.position) 
        {
            StartCoroutine(platfromWait1(3));
        }
        if (transform.position == pos2.position) 
        {
            StartCoroutine(platfromWait2(3));
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
    IEnumerator platfromWait1(float time)
    {
        yield return new WaitForSeconds(time);
        nextPos = pos2.position;
    }
    IEnumerator platfromWait2(float time)
    {
        yield return new WaitForSeconds(time);
        nextPos = pos1.position;
    }
}
