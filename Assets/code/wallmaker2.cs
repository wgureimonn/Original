using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wallmaker2 : MonoBehaviour {
	public static int[,] map;

	public GameObject wall;
	public GameObject wallu;
    public GameObject trap;
    public GameObject cli;
    public Text wc;
    public Text tc;
    private float reachaableDistance =200.0f;
    GameObject wallc;
    GameObject wallk;
    
    int x;
    int xa;
    float xf;
	int z;
    int za;
    int cs=0;
    int wco=17;
    int tco=5;
    float zf;
    Ray ray;
    RaycastHit hitInfo;
    Renderer blockRendrer;
    public Vector3 hitPos;
    public Vector3 seiseipos;
    public Camera pcamera;
    public Vector3 pos;
    public Vector3Int posint;
	// Use this for initialization
    void Awake(){
		map=new int[10,10];

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
        wc.text=wco.ToString();
        tc.text=tco.ToString();
        

		if (Input.GetMouseButtonDown(0)){
            Vector3 mpos= Input.mousePosition;
            ray = pcamera.ScreenPointToRay(mpos);
            bool isRayHit = Physics.Raycast(ray,out hitInfo, reachaableDistance);
            Debug.DrawRay(ray.origin,ray.direction*20,Color.red);
            if(isRayHit){
                if(hitInfo.collider.gameObject.CompareTag("wallmake")){
                    cs=0;
                    print(cs);
                    cli.gameObject.transform.position = new Vector3(1.3f,1,11.7f);
                }
                if(hitInfo.collider.gameObject.CompareTag("trapmake")){
                    cs=1;
                    print(cs);
                    cli.gameObject.transform.position = new Vector3(4.2f,1,11.7f);
                }
                if(hitInfo.collider.gameObject.CompareTag("floor")){
                    hitPos = hitInfo.collider.gameObject.transform.position;
                    seiseipos = hitPos + hitInfo.normal;
                    suuti();
                    if(cs==0&&wco>0){
                        seiseipos.y=1;
                        Instantiate(wall,seiseipos,Quaternion.identity);
                        map[xa,za]=2;           
                        wco--;             
                    }
                    if(cs==1&&tco>0){
                        seiseipos.y=0.5f;                        
                        Instantiate(trap,seiseipos,Quaternion.identity);  
                        map[xa,za]=3;  
                        tco--;                                            
                    }
                }
                else{
                    return;
                }
            }  
            
        }
        if (Input.GetMouseButtonDown(1)){
            Vector3 mpos= Input.mousePosition;
            //mpos.y =5;
            ray = pcamera.ScreenPointToRay(mpos);
            bool isRayHit = Physics.Raycast(ray,out hitInfo, reachaableDistance);
            Debug.DrawRay(ray.origin,ray.direction*20,Color.red);
            if(isRayHit){
                suuti();
                if(hitInfo.collider.gameObject.CompareTag("wall")){
                    
                   Destroy(hitInfo.collider.gameObject);
                   map[xa,za]=0;
                   wco++;
                }
                if(hitInfo.collider.gameObject.CompareTag("needle")){
                   Destroy(hitInfo.collider.gameObject);
                   map[xa,za]=0;
                   tco++;
                }
            }

            
        }
	}
    void suuti(){
        seiseipos.x=Mathf.RoundToInt(seiseipos.x);
        seiseipos.z=Mathf.RoundToInt(seiseipos.z);
        xa=(int)seiseipos.x;
        za=(int)seiseipos.z;
        seiseipos.y=1;
        print(seiseipos);
    }
}