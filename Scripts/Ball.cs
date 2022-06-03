using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {
  public AudioSource clip;

  void OnCollisionEnter2D(Collision2D coll)
  {
    clip.Play();
  }

}
