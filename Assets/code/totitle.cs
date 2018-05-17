using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class totitle : MonoBehaviour {
	public AudioClip cl3;
	private AudioSource au;
	// Use this for initialization
	void Start () {
		au = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClick3(){
		au.PlayOneShot(cl3);		
		SceneManager.LoadScene("title");
	}
}