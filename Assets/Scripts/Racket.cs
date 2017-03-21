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
		m_racket = gameObject;
		m_width = gameObject.GetComponent<Collider>().bounds.size.x;
		m_halfWidth = m_width / 2;
		float halfCameraWidth = Camera.main.orthographicSize * Camera.main.aspect;
		m_screenLeft = transform.position.x - halfCameraWidth;
		m_screenRight = transform.position.x + halfCameraWidth;
		m_ballRigidbody = ballObj.GetComponent<Rigidbody>();
	}
	
	void Update()
	{
		DirectionX direction = DirectionX.None;
        if (Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.position.x - m_halfWidth > m_screenLeft)
		{
			direction = DirectionX.Left;
			m_lastDirection = direction;
		}
		if (Input.GetKey(KeyCode.RightArrow) && gameObject.transform.position.x + m_halfWidth < m_screenRight)
		{
			direction = DirectionX.Right;
			m_lastDirection = direction;
		}
		gameObject.transform.Translate((float)direction * Constant.RACKET_SPEED, 0, 0, Space.Self);
		if (!m_doesStarted)
		{
			ballObj.transform.Translate((float)direction * Constant.RACKET_SPEED, 0, 0, Space.Self);
		}
		if (!m_doesStarted && Input.GetKey(KeyCode.Space))
		{
			m_doesStarted = true;
			m_ballRigidbody.AddRelativeForce(
				(float)m_lastDirection * Constant.BALL_SPEED * Constant.BALL_SPEED_MULTIPLIER / 2, 
				Constant.BALL_SPEED * Constant.BALL_SPEED_MULTIPLIER, 
				0);
		}
	}

	public static void Reset()
	{
		m_doesStarted = false;
		m_racket.transform.position = new Vector3(0, -8.8f, 0);
	}

	public static int GetStrength()
	{
		return m_strength;
	}

	public GameObject ballObj;
	private static GameObject m_racket;
	private static Rigidbody m_ballRigidbody;
	private static float m_width = 0;
	private static float m_halfWidth = 0;
	private static float m_screenLeft = 0;
	private static float m_screenRight = 0;
	private static DirectionX m_lastDirection = DirectionX.None;
	private static bool m_doesStarted = false;
	private static int m_strength = 1;
}
