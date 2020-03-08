using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFog : MonoBehaviour
{
    // The canvas panels that control the fog.
    public GameObject leftFog;
    public GameObject rightFog;
    // Makes the OnTriggerEnter only work once.
    bool fogStarted = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!fogStarted)
        {
            // Set starting time for the fog.
            MoveFog.startTime = Time.time;
            // Calculate the length we have to travel.
            leftFog.GetComponent<MoveFog>().journeyLength =
                Vector3.Distance(leftFog.GetComponent<MoveFog>()
                .startPos, MoveFog.endPos);
            rightFog.GetComponent<MoveFog>().journeyLength =
                 Vector3.Distance(rightFog.GetComponent<MoveFog>()
                 .startPos, MoveFog.endPos);
            // Starts the fog and makes sure it won't restart.
            MoveFog.startFog = true;
            fogStarted = true;
        }
    }
}
