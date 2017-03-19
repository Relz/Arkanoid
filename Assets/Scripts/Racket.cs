using UnityEngine;

public enum DirectionX
{
	None = 0,
	Right = 1,
	Left = -1
}

public enum DirectionY
{
	None = 0,
	Up = 1,
	Down = -1
}

public class Racket : MonoBehaviour 
{
	void Start () 
	{
		m_width = racketObj.GetComponent<Collider>().bounds.size.x;
		m_halfWidth = m_width / 2;
		float halfCameraWidth = Camera.main.orthographicSize * Camera.main.aspect;
		m_screenLeft = transform.position.x - halfCameraWidth;
		m_screenRight = transform.position.x + halfCameraWidth;
		ballRigidbody = ball.GetComponent<Rigidbody>();
	}
	
	void Update()
	{
		DirectionX direction = DirectionX.None;
        if (Input.GetKey(KeyCode.LeftArrow) && racketObj.transform.position.x - m_halfWidth > m_screenLeft)
		{
			direction = DirectionX.Left;
			m_lastDirection = direction;
		}
		if (Input.GetKey(KeyCode.RightArrow) && racketObj.transform.position.x + m_halfWidth < m_screenRight)
		{
			direction = DirectionX.Right;
			m_lastDirection = direction;
		}
		racketObj.transform.Translate((float)direction * Constant.RACKET_SPEED, 0, 0, Space.Self);
		if (!m_doesStarted && Input.GetKey(KeyCode.Space))
		{
			m_doesStarted = true;
			ballRigidbody.AddForce((float)m_lastDirection * Constant.BALL_SPEED * Constant.BALL_SPEED_MULTIPLIER, Constant.BALL_SPEED * Constant.BALL_SPEED_MULTIPLIER, 0);
		}
	}

	public GameObject racketObj;
	public GameObject ball;
	public Rigidbody ballRigidbody;
	private float m_width = 0;
	private float m_halfWidth = 0;
	private float m_screenLeft = 0;
	private float m_screenRight = 0;
	private DirectionX m_lastDirection = DirectionX.None;
	private bool m_doesStarted = false;
}
