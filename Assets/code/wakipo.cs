using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wakipo : MonoBehaviour {
	public GameObject enemy;
	public GameObject enemy2;

	// Use this for initialization
	void Start () {
		InvokeRepeating("waki",1,3);
		InvokeRepeating("waki2",1,3);
		
	}
	void waki(){
		Instantiate(enemy,transform.position,Quaternion.identity);
	}
	void waki2(){
		Instantiate(enemy2,transform.position,Quaternion.identity);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
