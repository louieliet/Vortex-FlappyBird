using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMovement : MonoBehaviour
{
    [SerializeField] private Vector2 bgvelocity;
    private Vector2 offset;
    private Material material;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material; 
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        offset = bgvelocity * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
