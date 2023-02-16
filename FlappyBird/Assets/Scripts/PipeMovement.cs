using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PipeMovement : MonoBehaviour
{
    public float speed;
    public float deadZone;

    void Update()
    {
        transform.position += new Vector3(-1,0,0) * Time.deltaTime * speed;

        if(transform.position.x < deadZone){
            Destroy(gameObject);
        }

    }
}