using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;   // Score
    public bool isDead = false; // Is the player dead?
    public Text scoreText;

    // Increase score
    public void AddScore(int amount)
    {
        score += amount; 
        scoreText.text = score.ToString();
    }

    // Change scene when dying
    public void Die()
    {
        // Set isDead to true
        isDead = true;
        // Print "You died!" to console
        Debug.Log("You died!");
        // Load the scene called "SampleScene"
        SceneManager.LoadScene("SampleScene");
    }
}