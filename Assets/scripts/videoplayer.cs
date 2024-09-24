using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Random = UnityEngine.Random;

public class videoplayer : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public VideoClip[] videoClips;
    public float maxMoveSpeed = 10;
    public float smoothTime = 0f;
    Vector2 currentVelocity;
    int videoSelector=0;
    
     void Start()
    {
      
    }


    void Update()

    {
        //funcion que detecta la posicion del raton u mueve el sprite en base a la velocidad de las variavles
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed); 
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            
        }
        RaycastHit hit;
        ////////
        ///
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {      videoSelector =  Random.Range(0,4);
        //play
            if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,Mathf.Infinity))
            {
            if(  hit.collider.gameObject.CompareTag("play") )
            {
                videoPlayer.clip = videoClips[videoSelector];
                videoPlayer.Play();
                

                
            }

            }
            //pause
            if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,Mathf.Infinity))
            {
            if(  hit.collider.gameObject.CompareTag("pause") )
            {
                if(videoPlayer.isPlaying)
                {
                
                videoPlayer.Pause();
                }
                else
                {
                    videoPlayer.Play();
                }
            }

            }

            //stop
            if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,Mathf.Infinity))
            {
            if(  hit.collider.gameObject.CompareTag("stop") )
            {
                if(videoPlayer.isPlaying)
                {
                
                videoPlayer.Stop();
                }
                if(videoPlayer.isPaused)
                {
                videoPlayer.Stop();     
                }
               

            }
            }

        }
    }  
}
