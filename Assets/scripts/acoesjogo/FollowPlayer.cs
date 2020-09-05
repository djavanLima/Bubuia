using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Pause Pause;
    public Transform player;
    public float smooth=0.5f;
    private Vector2 velocidade;
	// Use this for initialization
	void Start () {
		velocidade =new Vector2(0.5f,0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        if (Pause.pause==false) { 
        Vector2 novaposicao2D = Vector2.zero;
        novaposicao2D.x = Mathf.SmoothDamp(transform.position.x,player.position.x,ref velocidade.x, smooth);
        novaposicao2D.y = Mathf.SmoothDamp(transform.position.y, player.position.y, ref velocidade.y, smooth);

        Vector3 novaPosicao = new Vector3(novaposicao2D.x,novaposicao2D.y,transform.position.z);
        transform.position = Vector3.Slerp(transform.position,novaPosicao,Time.time);
        }
    }
}
