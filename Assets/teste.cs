using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour {
    public Transform target;
    public Quaternion RotaOlhar;
    public Vector3 distancia;
    Vector3 hero;
    public bool olhou;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       /* hero=target.position;
        distancia = transform.position - hero;
       RotaOlhar= Quaternion.LookRotation(distancia);
        transform.eulerAngles=new Vector3 (transform.eulerAngles.x,transform.eulerAngles.y,RotaOlhar.eulerAngles.z);*/
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        if (olhou==true) { 
       transform.LookAt(targetPosition);
            transform.eulerAngles = new Vector3((transform.eulerAngles.x+100), 83.645f, -93.09698f);
            olhou = false;
        }

    }
}
