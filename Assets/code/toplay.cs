using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class toplay : MonoBehaviour {
	public AudioClip cl2;
	private AudioSource au;
	// Use this for initialization
	void Start () {
		au = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClick2(){
		au.PlayOneShot(cl2);
		SceneManager.LoadScene("play");
	}
}
