using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public bool isWandering,isDown;
    void Update(){
        //if(Input.GetKeyDown(KeyCode.L))isWandering=!isWandering;
        if(isWandering){
            toPoint();
            isDown=false;
            
        }
        if(mode==3){
            isDown=true;
            isWandering=false;
        }
        Down();
    }
    void Start(){
        isWandering=true;
        isDown=false;
        hpSys=GameObject.FindGameObjectWithTag("Handler");
    }

    Vector2 target;
    void toPoint(){
            if(transform.position.x==target.x && transform.position.y==target.y){
                target=new Vector2(Random.Range(-8,8),Random.Range(-5f,5f));
                if(b<1){
                    decide();
                }
            }else{
                transform.position=Vector2.MoveTowards(transform.position, target, speed*Time.deltaTime);
            }
    }
    void decide(){
        mode=Random.Range(0,4);
    }
    int mode,a=0,b=0;
    void Down(){
        
        if(isDown){
            if(a<1){
                target=new Vector2(Random.Range(-8,8),Random.Range(-1.5f,1.5f));
                a++;
            }
            if(transform.position.x==target.x && transform.position.y==target.y){
                if(b<1){
                    hurting();
                    b++;
                }
            }else{
                transform.position=Vector2.MoveTowards(transform.position, target, speed*Time.deltaTime);
            }
        }
    }
    public float speed;
    void hurting(){
            StartCoroutine(delay());
    }
    public float jeda;
    IEnumerator delay(){
        yield return new WaitForSeconds(jeda);
        hpSys.GetComponent<HealthSystem>().getHurt();
        isWandering=true;
    }
    public GameObject hpSys;
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag=="Clap"){
            Destroy(gameObject);
        }
    }
}
