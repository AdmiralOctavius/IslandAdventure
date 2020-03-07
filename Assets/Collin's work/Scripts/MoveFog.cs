using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFog : MonoBehaviour
{
    // Trigger to start the fog.
    public GameObject fogTrigger;
    // Variables to hold the starting and ending positions of the 
    // fog.
    public Vector3 startPos;
    public static Vector3 endPos;
    // Movement speed in units per second.
    public float speed = 1.0F;
    // Start time.
    public static float startTime;
    // Length we have to go.
    public float journeyLength;
    // Used to trigger fog.
    public static bool startFog = false;

    // Start is called before the first frame update
    void Start()
    {
        // Take in the starting position.
        startPos = transform.position;
        endPos = Vector3.zero;
    }

    // FixedUpdate is called at a fixed time interval.
    void FixedUpdate()
    {
        if (startFog)
        {
            // Calculate the distance traveled so far.
            float distanceTraveled = (Time.time - startTime) * 20 * speed;
            // Turn this into a fraction of the journey completed.
            float fractionCompleted = distanceTraveled / journeyLength;
            // Actully moving the object.
            transform.position = Vector3.Lerp(startPos, endPos,
                fractionCompleted);
        }
    }
}
