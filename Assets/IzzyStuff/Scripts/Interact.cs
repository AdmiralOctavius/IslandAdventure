using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject parentGameObject;
    public Collider MostRecentObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
           /* Debug.Log("Button Pressed LMB");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;*/
            //Weird pathing

            parentGameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>().mouseLook.SetCursorLock(false);
            parentGameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>().typing = true;
        }
        if (Input.GetButtonDown("Cancel"))
        {
            /*Debug.Log("Button Pressed RMB");
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;*/
            parentGameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>().mouseLook.SetCursorLock(true);
            parentGameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>().typing = false;
        }

        if (Input.GetButtonDown("Talk"))
        {
            MostRecentObj.gameObject.GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "NPC")
        {
            MostRecentObj = other;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "NPC")
        {
            MostRecentObj = null;
        }
    }
}
