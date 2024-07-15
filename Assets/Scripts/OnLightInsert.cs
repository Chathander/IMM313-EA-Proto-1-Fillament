using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Serialization;

public class OnLightInsert : MonoBehaviour
{
    [SerializeField] private Skybox _skybox;
    public Light sunLight;
    public Color baseSunColor;
    public Color happySunColor;
    public Color madSunColor;
    public Color sadSunColor;
    [Space] 
    [SerializeField] private Material baseMaterial;
    [SerializeField] private Material happyMaterial;
    [SerializeField] private Material madMaterial;
    [SerializeField] private Material sadMaterial;
    [Header("Given Light Objects")]
    //I realize that I could just allow the artist of the team to input the lights into this section and have this
    //script find the component for them in the background and return a error that says the object dosn't contain
    //The script / auto add it in the background in awake! wholly molly I'm learning how to code!
    [SerializeField] private MoveObject lightObject1;
    [SerializeField] private MoveObject lightObject2;
    [SerializeField] private MoveObject lightObject3;
    
    
    [Space]
    [SerializeField] private AudioSource clickAudioSource;
    public AudioClip clickInClip;
    public AudioClip clickOutClip;
    

    private void OnTriggerEnter(Collider other)
    {
        lightObject2.inserted = true;
        lightObject1.inserted = true;
        lightObject3.inserted = true;

        clickAudioSource.clip = clickInClip;
        clickAudioSource.Play();
        
        if (other.CompareTag("HappyLight"))
        {
            _skybox.material = happyMaterial;
            sunLight.color = happySunColor;

        }
        else if (other.CompareTag("SadLight"))
        {
            _skybox.material = sadMaterial;
            sunLight.color = sadSunColor;
        }
        else if (other.CompareTag("MadLight"))
        {
            _skybox.material = madMaterial;
            sunLight.color = madSunColor;
        }
        else
        {
            return;
        }
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        lightObject2.inserted = false;
        lightObject1.inserted = false;
        lightObject3.inserted = false;
        //Debug.Log("lights can be inserted");
        _skybox.material = baseMaterial;
        
        clickAudioSource.clip = clickOutClip;
        clickAudioSource.Play();
        sunLight.color = baseSunColor;
    }

    private void skyboxChange()
    {
        
    }
}
