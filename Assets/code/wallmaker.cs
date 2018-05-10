using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmaker : MonoBehaviour {
	public static int[,] map;

	public GameObject wall;
	public GameObject wallu;
    GameObject wallc;
    GameObject wallk;
    int x;
    int xa;
	int z;
    int za;
	// Use this for initialization
    void Awake(){
		map=new int[10,10];

        wallmake();
        wallumake();
        
        
    }

    private void wallumake(){
        for (x = -1; x < 11; x++){
            for (z = -1; z < 11; z++){
                if ((x == 10) || (z == 10) || (z == -1) || (x == -1)){
                    Instantiate(wallu, new Vector3(x, 1, z), Quaternion.identity);
				}
            }
        }
    }

    private void wallmake()
    {
        for (x = 0; x < 5; x++){
            for(z=0;z<9;z++){
                xa=x*2;
                za=z+1;
                Instantiate(wall, new Vector3(xa, 1, za), Quaternion.identity);
                map[xa, za] = 2;
            }
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
