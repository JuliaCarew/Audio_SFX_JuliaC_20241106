using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviors : MonoBehaviour
{
    // Key Audio
    AudioSource C4;
    // Music Audio
    AudioSource music;
    public GameObject musicBox;
    public GameObject CubeC1;
    public bool notePressed;
    //public Material keyMaterial;
    //public Color keyPressed;

    private void Start()
    {
        music = GameObject.Find("musicBox").GetComponent<AudioSource>();

        C4 = GameObject.Find("CubeC1").GetComponent<AudioSource>();

        music.Play();
        Debug.Log("Music Playing");
        C4 = GetComponent<AudioSource>();
        notePressed = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        notePressed = true;
        C4.Play();
        Debug.Log("C1 Play");
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "MusicPauseButton")
        {
            music.Pause();
            Debug.Log("music paused");
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MusicPauseButton")
        {
            music.Play();
            Debug.Log("music unpaused");
        }      
    }
    /*
    public void ChangeKeyPlayedColor()
    {
        if (notePressed == true)
        {
            keyMaterial.color = keyPressed;
        }
    }
    */
}
// getting the error ArgumentNullException: Value cannot be null