using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PipeMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float moveSpeed = 5;
    public float deadZone = -10;

    void Update()
    {
        transform.position += new Vector3(-1,0,0) * Time.deltaTime;

        if(transform.position.x < -8){
            Destroy(gameObject);
        }

    }
}