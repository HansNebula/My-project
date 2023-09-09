using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    public GameObject aim, pf_clap;
    Vector3 pos;
    
    void Start(){
        Cursor.visible=false;
    }
    void Update(){
        followMouse();
        attack();
    }

    void followMouse(){
        pos=Input.mousePosition;
        pos.z=1f;
        aim.transform.position=Camera.main.ScreenToWorldPoint(pos);
    }

    void attack(){
        if(Input.GetMouseButtonDown(0)){
            GameObject palm=Instantiate(pf_clap, aim.transform.position, aim.transform.rotation);
			Destroy(palm,0.5f);
        }
    }
}
