using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmaker : MonoBehaviour {
	public static int[,] map2;

	public GameObject wall;
	public GameObject wallu;
    GameObject wallc;
    GameObject wallk;
    
    int x;
    int xa;
    float xf;
	int z;
    int za;
    float zf;

    public Vector3 pos;
    public Vector3Int posint;
	// Use this for initialization
    void Awake(){
        map2=new int[10,10];
        wallumake();      
    }
    void Start()
    {
        for(x=0;x<10;x++){
            for(z=0;x<10;z++){
                map2[x,z]=map2[x,z];
            }
        }
        wallmake();
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
        for (x=0;x<10;x++){
            for(z=0;z<10;z++){
                if(map2[x,z]==0){
                    Instantiate(wall, new Vector3(x, 1, z), Quaternion.identity);
                }
            }
        }

    }

    // Update is called once per frame
    void Update () {

		if (Input.GetMouseButtonDown(0)){
            
            pos =Input.mousePosition;
            suuti();
            Instantiate(wall,new Vector3(x,1,z),Quaternion.identity);
            
        }
	}
    void suuti(){
        xf=pos.x;
        zf=pos.y;
        xf=xf+0.5f;
        zf=zf+0.5f;
        x=(int)xf;
        z=(int)zf;
    }
}
