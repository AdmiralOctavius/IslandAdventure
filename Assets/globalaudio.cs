using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalaudio : MonoBehaviour
{

    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGameAudio()
    {
        //audio1.Play();
        audio2.Play();
        audio3.Play();
    }
}
