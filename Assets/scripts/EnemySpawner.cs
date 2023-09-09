using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefabMusuh;
	public int spawnSide;
    void Start(){
        mulai();
    }
 
    void Update(){
        
    }
    int wave=0;
    void Spawn(){
        for(int i=0;i<wave;i++){
            
        if(spawnSide == 0) {
            Instantiate(prefabMusuh, new Vector3(-12f, Random.Range(-6f, 6f), 0f), Quaternion.identity);
            spawnSide = Random.Range(0, 4);
        }
        else if(spawnSide == 1) {
            Instantiate(prefabMusuh, new Vector3(12f, Random.Range(-6f, 6f), 0f), Quaternion.identity);
            spawnSide = Random.Range(0, 4);
        }
        else if(spawnSide == 2) {
            Instantiate(prefabMusuh, new Vector3(Random.Range(-11f, 11f), -8f, 0f), Quaternion.identity);
            spawnSide = Random.Range(0, 4);
        }
        else if(spawnSide == 3) {
            Instantiate(prefabMusuh, new Vector3(Random.Range(-11f, 11f), 8f, 0f), Quaternion.identity);
            spawnSide = Random.Range(0, 4);
        }

        }
        wave++;
    }
    void mulai(){
        spawnSide = Random.Range(0, 4);
        InvokeRepeating("Spawn",2,3);
    }
}
