using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignCode : MonoBehaviour
{

    
    public string inputString;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeIslandName(string input)
    {
        inputString = input;
        Debug.Log("Changed island name to:" + inputString);
    }
}
