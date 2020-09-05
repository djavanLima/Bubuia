using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicou : MonoBehaviour {
    public static bool respondeu;
    public static bool perguntaAtiva;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (respondeu == true)
        {
            Destroy(gameObject);
        }

        if (perguntaAtiva== true)
        {
            gameObject.SetActive(true);
        }
    }
}
