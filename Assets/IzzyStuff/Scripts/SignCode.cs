using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignCode : MonoBehaviour
{

    
    public string inputString;
    public Text signText;
    public Text topText;
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
        topText.text = "This Island is called:";
        signText.text = inputString + " :)";
        this.gameObject.SetActive(false);
    }
}
