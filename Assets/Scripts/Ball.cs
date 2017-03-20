using UnityEngine;

public class Ball : MonoBehaviour 
{
	public void Start()
	{
		m_ball = gameObject;
		m_ballRigidbody = m_ball.GetComponent<Rigidbody>();
	}
	public static void Reset()
	{
		m_ball.transform.position = new Vector3(0, -7.78f, 0);
		m_ballRigidbody.velocity = Vector3.zero;
	}

	private static GameObject m_ball;
	private static Rigidbody m_ballRigidbody;
}
