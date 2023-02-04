using System.Collections;
using UnityEngine;

public class Trajectory : MonoBehaviour
{
    public Rigidbody2D rb; // the Rigidbody2D component of your character
    public GameObject trailPrefab; // the prefab for the trajectory object (e.g. particle system)
    public float trailInterval = 0.1f; // the interval at which to instantiate the trail objects
    private float timeSinceLastTrail = 0f; // time since last trail was instantiated

    void Update()
    {
        // increment the time since last trail
        timeSinceLastTrail += Time.deltaTime;

        // if the time since last trail is greater than the trail interval
        if (timeSinceLastTrail >= trailInterval)
        {
            // reset the time since last trail
            timeSinceLastTrail = 0f;

            // instantiate a new trail object at the current position of the character
            GameObject trail = Instantiate(trailPrefab, transform.position, Quaternion.identity);

            // set the velocity of the trail object to the velocity of the character
            trail.GetComponent<Rigidbody2D>().velocity = rb.velocity;
        }
    }
}
