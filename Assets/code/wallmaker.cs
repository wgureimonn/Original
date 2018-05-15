using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmaker : MonoBehaviour {

	public GameObject wall;
	public GameObject wallu;
    public GameObject trap;
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
        wallumake();      
    }
    void Start()
    {
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
                if(wallmaker2.map[x,z]==2){
                    Instantiate(wall, new Vector3(x, 1, z), Quaternion.identity);
                }
                if(wallmaker2.map[x,z]==3){
                    Instantiate(trap, new Vector3(x, 0.5f, z), Quaternion.identity);
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
