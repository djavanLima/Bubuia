using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Temporizador : MonoBehaviour {
    public int tLimite;
    public float minuto;
    public float segundo;
    private float varTrans;
     float contador;
    string aux;
    public static bool pergunta;
    public static bool reiniciarTemp;
    //public Text txtSegundo;
    public Text txtMinuto;
    //criar objeto de ControlP
    public ControlP ControlP;
    
    // Use this for initialization
    void Start () {
		
	}
    float decimo;
	// Update is called once per frame
	void FixedUpdate () {

        if (pergunta==true) { 
        // Debug.Log((int)Time.deltaTime);
        contador += 0.015f;
       
            aux = contador.ToString("0.0");
        decimo = float.Parse(aux);
        if (contador > 0.9)
        {
            contador = 0;
            segundo = segundo - 1;
            
        }

        if (segundo==-1)
        {// se chegar e 60 aumenta 1 minuto e zera segundos
            segundo = 59;
            minuto -= 1f;
        }

       
            
        //transformando em uma contagem confiavel
       
        

        }
        txtMinuto.text = minuto.ToString("0") + ":" + segundo.ToString("00");
        if (minuto==0 && segundo==0)
        {
           
            ControlP.errou();
            ControlP.TelaPergunta.SetActive(false);
            pergunta = false;
        }

    }

   

    public void nomarlizarCronometro()
    {
        segundo = 0;
        minuto = 3;
    }

}
