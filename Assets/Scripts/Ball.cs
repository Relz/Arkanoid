using UnityEngine;

public class Ball : MonoBehaviour 
{
	public void Start()
	{
		m_ball = gameObject;
		m_ballRigidbody = m_ball.GetComponent<Rigidbody>();
	}
	public void Update()
	{
		Vector3 ballDirection = m_ball.transform.InverseTransformDirection(m_ballRigidbody.velocity);
		if (Racket.DoesStarted() && ballDirection.x <= 0.1f && ballDirection.x >= -0.1f)
		{
			m_ballRigidbody.AddRelativeForce(0.5f, 0, 0);
		}
		Debug.Log(ballDirection.y);
		if (Racket.DoesStarted() && ballDirection.y <= 0.1f && ballDirection.y >= -0.1f)
		{
			m_ballRigidbody.AddRelativeForce(0, -0.5f, 0);
		}
	}
	public static void Reset()
	{
		m_ball.transform.position = new Vector3(0, -7.78f, 0);
		m_ballRigidbody.velocity = Vector3.zero;
	}

	private static GameObject m_ball;
	private static Rigidbody m_ballRigidbody;
}
