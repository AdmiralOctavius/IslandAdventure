using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killfloor : MonoBehaviour
{
    public GameObject respawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("got here in kill floor");
            other.gameObject.transform.position = respawn.transform.position;
        }
            
    }
}
