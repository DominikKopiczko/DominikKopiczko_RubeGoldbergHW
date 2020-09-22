using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour
{
    public AudioSource HeatWaves;
    public bool playing;
    // Start is called before the first frame update
    void Start()
    {
        playing = false;
        HeatWaves = GetComponent<AudioSource>();
    }


    void Update()
    {
        if(playing == false && Input.GetKeyDown(KeyCode.Space)){
            HeatWaves.Play();
            playing = true;
        }
        if(playing == true){

        }
    }

}
