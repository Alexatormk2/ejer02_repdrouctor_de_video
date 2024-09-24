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
 
    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    
    }

    void Update()
    {
        //para cerrar la app en la build
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            
        }
        //al pulsar click izquierdo inicia la reproduccion de audio en caso de que ya haiga una en reproduciendose la para e inica otra
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {  //se usa un random para esocer la cancion
             audioSelector =  Random.Range(0,4);
             audioSource.clip = audioClip[audioSelector];
             audioSource.Play();
          
            if(audioSource.isPlaying)
            {
                audioSource.Stop();
                audioSource.clip = audioClip[audioSelector];
                audioSource.Play();
                
                Debug.Log("hola ");
            }    
            
        }
        //click derecho pausa y despause le video
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
        //click central/rueda  para de forma completa el audio
        if(Input.GetKeyDown(KeyCode.Mouse2))
        {
           
                audioSource.Stop();
                Debug.Log("de deviar para");
                        
               
        }

    }
}
