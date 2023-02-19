using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public int Score = 0;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.Find("LogicManager").GetComponent<LogicScript>();
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            logic.AddScore(1);
        }
    }
        
}