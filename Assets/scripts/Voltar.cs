using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Voltar : MonoBehaviour {
    public GameOver GameOver;
    public SomJogo SomJogo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void btMenu(string a)
    {


      //  fazer   aqui

        if (a=="gameOver")
        {

        
        GameOver.clipButton();
        }

        if (a == "Sobre")
        {


            SomJogo.clipButton();
        }

        SceneManager.LoadScene(a);
        
    }
}

