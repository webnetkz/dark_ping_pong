using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PingPong : MonoBehaviour {

	public Transform player;
	public Transform bot;
	public Transform ball;
	public int startBallSpeed = 350;
	public float playerSpeed = 10;
	public float botSpeed = 2.5f;
	public float playerLimitY = 3.5f;
	public Text playerScoreText;
	public Text botScoreText;
	private int playerScore;
	private int botScore;
  private bool go;

	void Start () 
	{
		Reset(0);
	}

	void Update () 
	{
    // Управлениея пользователя
		if(Input.GetAxis("Vertical") > 0 && player.position.y < playerLimitY)
		{
			player.Translate(Vector2.up * playerSpeed * Time.deltaTime);
		}
		else if(Input.GetAxis("Vertical") < 0 && player.position.y > -playerLimitY)
		{
			player.Translate(-Vector2.up * playerSpeed * Time.deltaTime);
		}

    // Условия победы
		if(ball.position.x < 0)
		{
			float Y = Mathf.Lerp(bot.position.y, ball.position.y, botSpeed * Time.deltaTime);
			bot.position = new Vector2(bot.position.x, Y);
		}

		playerScoreText.text = playerScore.ToString();
		botScoreText.text = botScore.ToString();
	}

  // Перезагрузка
	public void Reset(float x)
	{
		ball.GetComponent<Rigidbody2D>().Sleep();
		bot.transform.position = new Vector2(bot.transform.position.x, 0);
		player.position = new Vector2(player.position.x, 0);
		ball.position = new Vector2(0, 0);
		if(x > 0) playerScore++; else if(x < 0) botScore++;

    if(playerScore == 10 || botScore == 10) {
      SceneManager.LoadScene(0);
    }

    if(go)
    {
      ball.GetComponent<Rigidbody2D>().WakeUp();
      Vector2 direction = new Vector2(1,Random.Range(1.5f, -1.5f)); // Стартавая рандомное направление движения
      if(Random.Range(0,2) == 1) direction.x *= -1;
      ball.GetComponent<Rigidbody2D>().AddForce(direction * startBallSpeed);
    }

    go = true;
	}
}