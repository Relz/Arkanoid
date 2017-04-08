using UnityEngine;
using UnityEngine.UI;

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
		Vector3 leftWallCollider = leftWallObj.GetComponent<Collider>().bounds.size;
		Vector3 rightWallCollider = rightWallObj.GetComponent<Collider>().bounds.size;
		m_leftWalRight = leftWallObj.transform.position.x + leftWallCollider.x;
		m_rightWallLeft = rightWallObj.transform.position.x - rightWallCollider.x;
		m_ballRigidbody = ballObj.GetComponent<Rigidbody>();
		m_source = gameObject.GetComponent<AudioSource>();
		m_livesValueObjText = livesValueObj.GetComponent<Text>();
		m_livesValueObjText.text = m_lives.ToString();
	}
	
	void Update()
	{
		DirectionX direction = DirectionX.None;
		if (Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.position.x - m_halfWidth > m_leftWalRight)
		{
			direction = DirectionX.Left;
			m_lastDirection = direction;
		}
		if (Input.GetKey(KeyCode.RightArrow) && gameObject.transform.position.x + m_halfWidth < m_rightWallLeft)
		{
			direction = DirectionX.Right;
			m_lastDirection = direction;
		}
		gameObject.transform.Translate((float)direction * Constant.RACKET.SPEED, 0, 0, Space.Self);
		if (!m_doesStarted)
		{
			ballObj.transform.Translate((float)direction * Constant.RACKET.SPEED, 0, 0, Space.Self);
		}
		if (!m_doesStarted && Input.GetKey(KeyCode.Space))
		{
			m_doesStarted = true;
			m_ballRigidbody.AddRelativeForce(
				(float)m_lastDirection * Constant.BALL.SPEED * Constant.BALL.SPEED_MULTIPLIER / 2, 
				Constant.BALL.SPEED * Constant.BALL.SPEED_MULTIPLIER, 
				0);
		}
	}

	void Awake()
	{
		m_lives = Constant.RACKET.HP;
		m_strength = 1;
		m_doesStarted = false;
		m_lastDirection = DirectionX.None;
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

	public static bool DoesStarted()
	{
		return m_doesStarted;
	}

	public static int GetLives()
	{
		return m_lives;
	}

	public static void DecrementLives()
	{
		--m_lives;
		m_livesValueObjText.text = m_lives.ToString();
	}
	void OnCollisionEnter(Collision col)
	{
		m_source.PlayOneShot(touchSound);
	}

	public GameObject ballObj;
	public GameObject leftWallObj;
	public GameObject rightWallObj;
	public AudioClip touchSound;
	public GameObject livesValueObj;
	private static Text m_livesValueObjText;
	private AudioSource m_source;
	private static GameObject m_racket;
	private static Rigidbody m_ballRigidbody;
	private static float m_width = 0;
	private static float m_halfWidth = 0;
	private static float m_leftWalRight = 0;
	private static float m_rightWallLeft = 0;
	private static DirectionX m_lastDirection = DirectionX.None;
	private static bool m_doesStarted = false;
	private static int m_strength = 1;
	private static int m_lives = Constant.RACKET.HP;
}
