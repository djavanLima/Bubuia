using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public SomJogo SomJogo;
    public Button iniciar;
    public Button tutorial;
    public Button audio;
    public Button sair;
    public Button sobre;
    
    public Text telaAudio;
    public Text telaSair;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }



    public void carregarCena(string cena) {
        SomJogo.clipButton();
        StartCoroutine(temp(cena));

    }

    IEnumerator temp(string cena)

    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(cena);


    }

   public void btnAudio()
    {

        SomJogo.clipButton();
        iniciar.gameObject.SetActive(false);
   tutorial.gameObject.SetActive(false); 
     sair.gameObject.SetActive(false); 
    sobre.gameObject.SetActive(false); 
 
    audio.gameObject.SetActive(false);
    telaAudio.gameObject.SetActive(true); 




}


    public void btnVoltarAudio()
    {
        
        SomJogo.clipButton();
        iniciar.gameObject.SetActive(true);
        tutorial.gameObject.SetActive(true);
        sair.gameObject.SetActive(true);
        sobre.gameObject.SetActive(true);
       
        audio.gameObject.SetActive(true);
        telaAudio.gameObject.SetActive(false);




    }

    // btnaudio em jogo

    public void jogandoAudio()
    {
    
        if (telaAudio.gameObject.activeInHierarchy == true )
        {
             telaAudio.gameObject.SetActive(false);
            Debug.Log("desativou");
           

        }

        else{

            telaAudio.gameObject.SetActive(true);
            Debug.Log("ativou");
       
        }


        



    }



    public void btnSair()
    {

        iniciar.gameObject.SetActive(false);
        tutorial.gameObject.SetActive(false);
        sair.gameObject.SetActive(false);
        sobre.gameObject.SetActive(false);
       
        audio.gameObject.SetActive(false);
        telaSair.gameObject.SetActive(true);

        //Application.Quit(); funcao para sair do jogo



    }



    public void Sair()
    {

        Application.Quit();




    }


    public void btnVoltarSair()
    {

        iniciar.gameObject.SetActive(true);
        tutorial.gameObject.SetActive(true);
        sair.gameObject.SetActive(true);
        sobre.gameObject.SetActive(true);
      
        audio.gameObject.SetActive(true);
        telaSair.gameObject.SetActive(false);

     


    }
    public GameObject telaSelection;
    public GameObject telaMenu;
    public void btnVoltarSelection()
    {
        telaSelection.SetActive(false);
        telaMenu.SetActive(true);
    }
    public void activeSelection()
    {

        telaSelection.SetActive(true);
        telaMenu.SetActive(false);
    }

}
