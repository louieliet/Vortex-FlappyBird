using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public int Score = 0;
    public LogicScript logic;

    void Start()
    {
        logic =GameObject.Find("GameManager").GetComponent<LogicScript>();
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.tag=="Player")
        {
            logic.AddScore(1);
        }
    }
}