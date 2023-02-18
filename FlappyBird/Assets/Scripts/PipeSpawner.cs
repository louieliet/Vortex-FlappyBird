using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 1f;
    private float timer = 0f;
    public float difference = 2.0f; 

    private void Start()
    {
        spawnPipe();
    }
    
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe(){
        float topLimit = transform.position.y + difference ;
        float bottomLimit = transform.position.y - difference;
        float randomHeight = Random.Range(bottomLimit,topLimit);
        Instantiate(pipePrefab, 
            new Vector3(transform.position.x + 5.0f, randomHeight, 0), 
            pipePrefab.transform.rotation);
    }
}
