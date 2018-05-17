using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {
    public bool DontDestroyEnabled = true;

    void Start () {
        if (DontDestroyEnabled) {
            
            DontDestroyOnLoad (this);
        }
    }
    void Update () {

    }
}

