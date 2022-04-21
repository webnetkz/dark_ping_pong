using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public PingPong pingPomg;
  public AudioSource clip;

  void OnCollisionEnter2D(Collision2D coll)
  {
    clip.Play();
  }

	void OnBecameInvisible () 
	{
		pingPomg.Reset(transform.position.x);
	}
}
