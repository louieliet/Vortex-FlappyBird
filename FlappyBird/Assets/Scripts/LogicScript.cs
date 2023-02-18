using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;   // Score
    public bool isDead = false; // Is the player dead?

    // Increase score
    public void AddScore(int amount)
    {
        // Add amount to score
        score += amount; 
        // Print score to console
        Debug.Log("Score: " + score); 
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