using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{

  public float whoWin;

  public PingPong myGame;
  void OnTriggerEnter2D(Collider2D col)
  {
    myGame.Reset(whoWin);
  }
}
