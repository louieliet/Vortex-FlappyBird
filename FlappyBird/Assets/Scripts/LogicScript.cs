using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score =0;  //Score
    public bool isDead=false;

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: "+score);
    }
   
    public void Die(){
        isDead = true;
        SceneManager.LoadScene("SampleScene");
    }
}