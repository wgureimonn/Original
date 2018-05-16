using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flush : MonoBehaviour {
	Image img;
	public static bool flag3;
	// Use this for initialization
	void Start () {
		img = GetComponent<Image>();
		img.color = Color.clear;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(flag3){	
			this.img.color = new Color(0.5f,0f,0f,0.5f);
			flag3 =false;
		}
		this.img.color = Color.Lerp(this.img.color,Color.clear,Time.deltaTime);
		
	}
}
