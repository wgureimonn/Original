using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;

public class ppp : MonoBehaviour {

    PostProcessingBehaviour behaviour;
    GrainModel.Settings grainsetting;
	public static bool flag4;
	// Use this for initialization
	void Start () {

		behaviour = GetComponent<PostProcessingBehaviour>();
		mati();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (flag4)
        {
            grainsetting = behaviour.profile.grain.settings;
            grainsetting.intensity = 0.5f;
            behaviour.profile.grain.settings = grainsetting;
			Invoke("mati",0.5f);
            flag4 = false;
        }
    }

    private void mati()
    {
        grainsetting = behaviour.profile.grain.settings;
        grainsetting.intensity = 0;
        behaviour.profile.grain.settings = grainsetting;
    }
}
