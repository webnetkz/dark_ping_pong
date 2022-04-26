using UnityEngine;
using System.Collections;

public class colorChange : MonoBehaviour 
{
    public GameObject cube;
    private Renderer rend;

    private void OnCollisionEnter2D (Collision2D col)
    {
        if (col.collider.name == "Player" || col.collider.name == "Bot")
        {
          
        }
    }
}