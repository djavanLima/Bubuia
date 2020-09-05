using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SomJogo : MonoBehaviour {
    public AudioClip soundButton;
    public AudioSource Sfx;
    public AudioSource soundFundo;
    public Toggle audioDes;
    public Toggle audioLig;
    
    private void Awake()
    {

        if (ControlP.som == false)
        {
            
            Sfx.mute = true;
            soundFundo.mute = true;
            audioLig.isOn = false;
            audioDes.isOn=true;
            
        }
        if(ControlP.som == true)
        { 
            Sfx.mute = false;
            soundFundo.mute = false;
            audioLig.isOn = true;
            audioDes.isOn = false;
        }

    }
    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

       
       

		
	}
    public void selctAudOn()

    {
        if (ControlP.som == false) {
        ControlP.som = true;
        clipButton();
        Sfx.mute = false;
        soundFundo.mute = false;

            //  PlayerPrefs.SetInt("som",0);
        }


    }
    public void selctAudOff()

    {
        // PlayerPrefs.SetInt("som", 1);

        if (ControlP.som == true)
        {
            ControlP.som = false;

            Sfx.mute = true;
            soundFundo.mute = true;
        }

    }

    public void clipButton() {

        Sfx.PlayOneShot(soundButton);


    }


}
