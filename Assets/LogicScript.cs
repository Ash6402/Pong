using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject p1;
    public GameObject p2;
    public BallScript ballScript;
    public PaddleHandler paddleHandler;
    public Text startText;
    public Text player1Score;
    public Text player2Score;
    private int _scoreP1;
    private int _scoreP2;
    private Rigidbody2D _ballRigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        _ballRigidBody = ball.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x < p1.transform.position.x - 5)
        {
            SetPlayer2Score();
            ResetGame(); 
        }

        if (ball.transform.position.x > p2.transform.position.x + 5)
        {
            SetPlayer1Score();
            ResetGame();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballScript.Move();
        }

        startText.enabled = _ballRigidBody.velocity.x == 0;
    }

    private void SetPlayer1Score()
    {
        player1Score.text = (++_scoreP1).ToString();
    }
    
    private void SetPlayer2Score()
    {
        player2Score.text = (++_scoreP2).ToString();
    }

    private void ResetGame()
    {
        ballScript.ResetBall();
        paddleHandler.ResetPaddles();
    }
}
