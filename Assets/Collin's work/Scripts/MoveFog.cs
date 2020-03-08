using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveFog : MonoBehaviour
{
    // Trigger to start the fog.
    public GameObject fogTrigger;
    // Empty GameObject to be the endpoint of the motion.
    public GameObject endSpot;
    // GameObject for a gray screen that appears when the animation is over.
    public GameObject staticFog;
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
        endPos = endSpot.transform.position;
    }

    // FixedUpdate is called at a fixed time interval.
    void FixedUpdate()
    {
        // Make sure the fog stays in the right spot.
        transform.Translate(
            Camera.main.gameObject.transform.position.x,
            Camera.main.gameObject.transform.position.y,
            transform.position.z);
        // If it's time to start the fog...
        if (startFog)
        {
            // Calculate the distance traveled so far.
            float distanceTraveled = (Time.time - startTime) * 20 * speed;
            // Turn this into a fraction of the journey completed.
            float fractionCompleted = distanceTraveled / journeyLength;
            // Actully moving the object.
            transform.position = Vector3.Lerp(startPos, endPos,
                fractionCompleted);
            // Right before the fog finishes moving, activate static fog.
            if (fractionCompleted <= 1 && fractionCompleted > 0.99)
            {
                // Activate the static fog.
                staticFog.gameObject.SetActive(true);
            }
            // Once the fog has finished moving, load the next scene.
            if (transform.position == endPos)
            {
                // Load the scene for main game.
                SceneManager.LoadScene(2);
            }
        }
    }
}
