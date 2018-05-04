using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dungeonmaker : MonoBehaviour {
int x;
int z;
public GameObject zimen;
public GameObject kabesita;
public GameObject kabeue;
public GameObject kabemigi;
public GameObject kabehidari;
public GameObject kabekado;
public GameObject floor;
public GameObject wall;

    public GameObject Kabehidari
    {
        get
        {
            return kabehidari;
        }

        set
        {
            kabehidari = value;
        }
    }

    // Use this for initialization
    void Start () {
		for(x=0;x<10;x++){
			for(z=0;z<10;z++){
				GameObject floorc = Instantiate(zimen,new Vector3(x,0,z),Quaternion.identity);
				floorc.transform.parent = floor.transform;
			}
		}
		for(x=-1;x<11;x++){
			for(z=-1;z<11;z++){
				if((x==10)&&((z==10)||(z==-1))||((x==-1)&&((z==10)||(z==-1)))){
					GameObject wallc = Instantiate(kabekado,new Vector3(x,0,z),Quaternion.identity);
					wallc.transform.parent = wall.transform;
				}
				else if(z==-1){
					GameObject wallc = Instantiate(kabesita,new Vector3(x,0,z),Quaternion.identity);
					wallc.transform.parent = wall.transform;
				}
				else if(z==10){
					GameObject wallc = Instantiate(kabeue,new Vector3(x,0,z),Quaternion.identity);
					wallc.transform.parent = wall.transform;
				}
				else if(x==10){
					GameObject wallc = Instantiate(Kabehidari,new Vector3(x,0,z),Quaternion.identity);
					wallc.transform.parent = wall.transform;
				}
				else if(x==-1){
					GameObject wallc = Instantiate(kabemigi,new Vector3(x,0,z),Quaternion.identity);
					wallc.transform.parent = wall.transform;
				}
			}
		}
		
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
