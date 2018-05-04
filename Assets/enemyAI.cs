using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour {
	int now;
	int score;
	int suitei;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("up")){
			transform.position -= new Vector3(1,0,0);
		}
		if(Input.GetKeyDown("down")){
			transform.position += new Vector3(1,0,0);
		}
		if(Input.GetKeyDown("right")){
			transform.position += new Vector3(0,0,1);
		}
		if(Input.GetKeyDown("left")){
			transform.position -= new Vector3(0,0,1);
		}
		
	}
}
