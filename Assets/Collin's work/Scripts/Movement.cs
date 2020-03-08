using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // The boat's starting and ending points.
    public GameObject startPoint;
    public GameObject endPoint;
    // Movement speed in units per second.
    public float speed = 1.0F;
    // Start time.
    private float startTime;
    // Length we have to go.
    private float journeyLength;
    // Bool for making boat sink in island scene.
    public bool dockHit = false;
    public AudioSource bonk;

    // Start is called before the first frame update.
    private void Start()
    {
        // Track the starting time.
        startTime = Time.time;
        // Calculate the length we have to travel.
        journeyLength = 
            Vector3.Distance(startPoint.transform.position, 
            endPoint.transform.position);
    }

    // FixedUpdate is called at a fixed time interval.
    void FixedUpdate()
    {
        if (!dockHit)
        {
            // Calculate the distance traveled so far.
            float distanceTraveled = (Time.time - startTime) * 10 * speed;
            // Turn this into a fraction of the journey completed.
            float fractionCompleted = distanceTraveled / journeyLength;
            // Actully moving the object.
            transform.position = Vector3.Lerp(startPoint.transform
                .position, endPoint.transform.position,
                fractionCompleted);
        }
        // Activate dockHit bool.
        if (transform.position == endPoint.transform.position)
        {
            dockHit = true;
            bonk.Play();
        }
        if (dockHit)
        {
            SinkBoat();
        }
    }

    public void SinkBoat()
    {
        if (transform.position.y >= -5f)
        {
            Debug.Log("got here");
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.25f, transform.position.z);
        }
    }
}
