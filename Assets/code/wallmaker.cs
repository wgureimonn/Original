using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmaker : MonoBehaviour {
	int [,] map=new int[10,10];
    int [,] OC =new int[10,10];
    int [,] SI =new int[10,10];
    int [,] C  =new int[10,10];
    int [,] SC =new int[10,10];
    int Gx=3;
    int Gz=4;
    int cc=1;
    int cp;

	int x;
    int xa;
	int z=0;
    int za;
	public GameObject wall;
	public GameObject wallu;
    GameObject wallc;
    GameObject wallk;
	// Use this for initialization
	void Start ()
    {
        wallmake();
        wallumake();
        openclose();
        suitei();
        cost();
        score();
        for (x = 0; x < 10; x++)
        {
            for (z = 0; z < 10; z++)
            {
                Debug.Log(SC[x, z]);
            }
        }
        
        
    }

    private void score()
    {
        for (x = 0; x < 10; x++)
        {
            for (z = 0; z < 10; z++)
            {
                if (OC[x, z] == 0||OC[x,z]==1)
                {
                    SC[x,z]=SI[x,z]+C[x,z];
                }
            }
        }
    }

    private void cost(){
        while(true){
            cp=0;
            for (x = 0; x < 10; x++)
            {
                for (z = 0; z < 10; z++)
                {
                    
                    if (C[x,z]==cc)
                    {
                        if(OC[x,z+1]==0){
                            C[x,z+1] =C[x,z]+1;
                            OC[x,z+1]=1;
                            cp=1;
                       }
                        if(OC[x+1,z]==0){
                            C[x+1,z] =C[x,z]+1;
                            OC[x+1,z]=1;
                            cp=1;
                        }
                        if(OC[x,z-1]==0){
                            C[x,z-1] =C[x,z]+1;
                            OC[x,z-1]=1;
                            cp=1;
                       }
                        if(OC[x-1,z]==0){
                            C[x-1,z] =C[x,z]+1;
                            OC[x-1,z]=1;
                            cp=1;
                        }
                    }
                }
            }
            cc++;
            if(cp==0)break;
        }
    }

    private void suitei()
    {
        for (x = 0; x < 10; x++)
        {
            for (z = 0; z < 10; z++)
            {
                if(map[x,z]==0){
                    SI[x,z]=Mathf.Abs(Gx-x)+Mathf.Abs(Gz-z);
                }
            }
        }
    }

    private void debugg()
    {
        for (x = 0; x < 10; x++)
        {
            for (z = 0; z < 10; z++)
            {
                Debug.Log(map[x, z]);
            }
        }
    }

    private void openclose()
    {
        for (x = 0; x < 10; x++)
        {
            for (z = 0; z < 10; z++)
            {
                OC[x,z]=map[x,z];
            }
        }
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
                za=z+1-x%2;
                Instantiate(wall, new Vector3(xa, 1, za), Quaternion.identity);
                map[xa, za] = 2;
            }
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
