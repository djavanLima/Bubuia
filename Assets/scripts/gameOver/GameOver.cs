using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class GameOver : MonoBehaviour {

    // Use this for initialization
   public  Text pontoP1;
   public Text pontoP2;
    public GameObject[] estrela;



    // controle de som relacionado ao jogo
    public AudioClip soundButton;
    public AudioSource Sfx; // controla o nivel de como vai ser utilizado o audio do botão
    public AudioSource soundFundo;



    private void Awake()
    {

        if (ControlP.som == false)
        {

            Sfx.mute = true;
            soundFundo.mute = true;
            

        }
        if (ControlP.som == true)
        {
            Sfx.mute = false;
            soundFundo.mute = false;
          
        }

    }


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        pontoP1.text =  ControlP.countj1.ToString();
        pontoP2.text =  ControlP.countj2.ToString();

      


        verifyWinner();
    }






    public void verifyWinner()
    {
        
        if (ControlP.jogadorVencedor == 1)
        {
            estrela[0].SetActive(true);
        }
        else if (ControlP.jogadorVencedor==2) {
            estrela[1].SetActive(true);
              

        }

    }

    public void audioController()

    {

    }
    public void clipButton()
    {

        Sfx.PlayOneShot(soundButton);


    }

}
