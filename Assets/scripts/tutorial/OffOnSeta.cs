using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffOnSeta : MonoBehaviour {
    public ControlP ControlP;
    public int i;
    public float tempo;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

       


        tempo += 0.01f;
        if (tempo > 0.5)
        {
            GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;


            tempo = 0;



        }
        if (ControlP.piscarSeta==false) { 
        Destroy(gameObject);
        }
    }
}



