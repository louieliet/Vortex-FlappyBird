using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 1f;
    private float timer = 0f;

    private void Start()
    {
        spawnPipe();
    }
    
    void Update()
    {
        if(timer > spawnRate){
            timer = 0f;
            spawnPipe();
        }
        else{
            timer += Time.deltaTime;
        }
    }

    void spawnPipe(){
        Instantiate(pipePrefab, new Vector3(10,0,0), pipePrefab.transform.rotation);
    }
}
