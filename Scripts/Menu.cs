using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
  public GameObject menuPanel;
  public GameObject settingsPanel;
  public GameObject ball;
  public float startBallSpeed = 350f;

  void Start()
  {
    ball.SetActive(false);
  }

  public void ExitMyGame()
  {
    Application.Quit();
  }

  public void PauseMyGame()
  {
    menuPanel.SetActive(true);
    Time.timeScale = 0;
  }

  public void ContinueMyGame()
  {
    menuPanel.SetActive(false);
    Time.timeScale = 1;
  }

  public void OpenMySettings()
  {
    settingsPanel.SetActive(true);
    menuPanel.SetActive(false);
  }

  public void CloseMySettings()
  {
    settingsPanel.SetActive(false);
    menuPanel.SetActive(true);
  }

  public void StartMyGame()
  {
    ball.SetActive(true);
    ContinueMyGame();
		ball.GetComponent<Rigidbody2D>().WakeUp();
		Vector2 direction = new Vector2(1,Random.Range(1.5f, -1.5f)); // Стартавая рандомное направление движения
		if(Random.Range(0,2) == 1) direction.x *= -1;
		ball.GetComponent<Rigidbody2D>().AddForce(direction * startBallSpeed);
  }
}
