using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public bool birdIsAlive = true;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        logic = GameObject.Find("GameManager").GetComponent<LogicScript>();
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && logic.isDead == false)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic.Die();
    }


}
