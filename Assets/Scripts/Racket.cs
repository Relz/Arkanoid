using UnityEngine;

public enum Direction
{
	None = 0,
	Right = 1,
	Left = -1
}

public class Racket : MonoBehaviour 
{
	public delegate void onMove(float x, float y = 0, float z = 0);

	void Start () 
	{
		m_width = racketObj.GetComponent<Collider>().bounds.size.x;
		m_halfWidth = m_width / 2;
		float halfCameraWidth = Camera.main.orthographicSize * Camera.main.aspect;
		m_screenLeft = transform.position.x - halfCameraWidth;
		m_screenRight = transform.position.x + halfCameraWidth;
	}
	
	void Update()
	{
		Direction direction = Direction.None;
        if (Input.GetKey("left") && racketObj.transform.position.x - m_halfWidth > m_screenLeft)
		{
			direction = Direction.Left;
		}
		if (Input.GetKey("right") && racketObj.transform.position.x + m_halfWidth < m_screenRight)
		{
			direction = Direction.Right;
		}
		racketObj.transform.Translate((float)direction * m_xSpeed, 0, 0, Space.Self);
		if (Input.GetKey("space"))
		{
			Debug.Log("Space");
		}
	}

	public GameObject racketObj;
	private float m_xSpeed = 0.7f;
	private float m_width = 0;
	private float m_halfWidth = 0;
	private float m_screenLeft = 0;
	private float m_screenRight = 0;
}
