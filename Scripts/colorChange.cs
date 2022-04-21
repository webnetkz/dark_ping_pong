using UnityEngine;
using System.Collections;

public class colorChange : MonoBehaviour 
{
    public GameObject cube;
    private Renderer rend;

    // Use this for initialization
    void Start () 
    {

    }

    // Update is called once per frame
    void Update ()
    {
      Color newColor = new Color(
        Random.Range(0f, 1f), 
        Random.Range(0f, 1f), 
        Random.Range(0f, 1f)
      );

      if (Input.GetKeyDown (KeyCode.O))
          GetComponent<Renderer> ().material.color = newColor;
      }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.collider.name == "Player" || col.collider.name == "Bot")
        {
          Color newColor = new Color(
            Random.Range(0f, 1f), 
            Random.Range(0f, 1f), 
            Random.Range(0f, 1f)
          );
          GetComponent<Renderer> ().material.color = newColor;
        }
    }
}