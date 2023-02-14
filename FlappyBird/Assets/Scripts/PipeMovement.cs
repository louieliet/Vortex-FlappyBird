using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PipeMovement : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        transform.position += new Vector3(-1,0,0) * Time.deltaTime;
    }
}