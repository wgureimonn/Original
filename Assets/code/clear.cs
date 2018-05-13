using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour {
	public Text time;
	public static float zikan=30.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		zikan -= Time.deltaTime;
		time.text = "Time : "+zikan.ToString("f2");
		if (zikan <0){
			SceneManager.LoadScene("clear");
		}
	}
}
