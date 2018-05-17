using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class title2 : MonoBehaviour {
	public AudioClip cl;
	private AudioSource au;
	void Start () {
		au = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClick(){
		au.PlayOneShot(cl);
		SceneManager.LoadScene("setume");
	}
}
