using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PingPong : MonoBehaviour {

	public Transform player;
	public Transform bot;
	public Transform ball;
	public int startBallSpeed;
	public float playerSpeed;
	public float botSpeed;
	public float playerLimitX;
	public Text playerScoreText;
	public Text botScoreText;
	private int playerScore;
	private int botScore;
	private bool go;
	private float accelerationX;
	private float playerPositionX;

	void Start () 
	{
		Reset(0);
	}

	void Update ()  
	{
    accelerationX = Input.acceleration.x;
    playerPositionX = accelerationX * playerLimitX;

    player.position = new Vector2(playerPositionX, player.position.y);

    // Управление ботом
		if(ball.position.y < 0 || ball.position.y > 0)
		{
			float X = Mathf.Lerp(bot.position.x, ball.position.x, botSpeed * Time.deltaTime);
			bot.position = new Vector2(X, bot.position.y);
		}

		playerScoreText.text = playerScore.ToString();
		botScoreText.text = botScore.ToString();
	}

  // Перезагрузка
	public void Reset(float x)
	{
		ball.GetComponent<Rigidbody2D>().Sleep(); // Останавливаем шар
		bot.transform.position = new Vector2(bot.transform.position.x, 14f); // Выставляем на стартовую позицию бота
		player.position = new Vector2(player.position.x, -14f); // Выставляем на стратовую позицию игрока
		ball.position = new Vector2(0, 0); // Выставляем на стартовую позицию мяч
		if(x > 0) playerScore++; else if(x < 0) botScore++; // В завизимости от переданного значения в этот медод, добавляем очко боту или игроку

    if(playerScore == 10 || botScore == 10) { // Условия завершения игровой сессии
      SceneManager.LoadScene(0);
    }

    if(go)
    {
      ball.GetComponent<Rigidbody2D>().WakeUp();
      Vector2 direction = new Vector2(Random.Range(1f, -1f), 1); // Стартавая рандомное направление движения
      if(Random.Range(0,2) == 1) direction.x *= -1;
      ball.GetComponent<Rigidbody2D>().AddForce(direction * startBallSpeed);
    }

    go = true;
	}
}
