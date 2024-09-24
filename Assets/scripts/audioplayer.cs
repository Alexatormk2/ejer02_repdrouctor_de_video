using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class audioplayer : MonoBehaviour
{
    //variables para guardar los audios y el que reproduce los audios 
    public AudioSource audioSource;
    public AudioClip[] audioClip;
    int audioSelector=0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {  
             audioSelector =  Random.Range(0,4);
             audioSource.clip = audioClip[audioSelector];
             audioSource.Play();
          
            if(audioSource.isPlaying)
            {
                audioSource.Stop();
                audioSource.clip = audioClip[audioSelector];
                audioSource.Play();
                
               // audioSource.PlayOneShot(audioClip[1]);
                Debug.Log("hola ");
            }    
            
        }
        if( Input.GetKeyDown(KeyCode.Mouse1)) 
        {
            if(  audioSource.isPlaying)
            {

                audioSource.Pause();
            }
                else{

                    audioSource.UnPause();

                    }
        
        }
        if(Input.GetKeyDown(KeyCode.Mouse2))
        {
           
                audioSource.Stop();
                Debug.Log("de deviar para");
                        
               
        }

    }
}
