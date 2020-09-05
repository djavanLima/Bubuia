using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
    public SomJogo SomJogo;
    public Button btnMenu;
    public Button btnInciar;
    public bool pause;
    public ControlP ControlP;
    // colocar opção de áudio

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void botoesOff()

    {
        SomJogo.clipButton();
        if (pause==false)
        {


            btnInciar.interactable = false;
            btnMenu.interactable = false;
            pause = true;
        }
        else
        {
            if (ControlP.lancarBool==false) { // jogo em execucao
            btnInciar.interactable = true;
            }
            btnMenu.interactable = true;
            pause = false;

        }
    }
}
