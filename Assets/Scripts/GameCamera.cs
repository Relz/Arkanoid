using UnityEngine;

public class GameCamera : MonoBehaviour 
{
	private void Start()
	{
		gameCamera = gameObject.GetComponent<Camera>();
	}
	void Update()
	{
		Vector3 position = gameObject.transform.position;
		Quaternion rotation = gameObject.transform.rotation;
		position.x = racket.transform.position.x / 20;
		position.y = ball.transform.position.y / 20;
		rotation.y = -position.x / 40;
		rotation.x = position.y / 20;
		gameObject.transform.position = position;
		gameObject.transform.rotation = rotation;
	}

	public static void SetActive(bool value)
	{
		gameCamera.enabled = value;
	}

	public GameObject racket;
	public GameObject ball;
	private static Camera gameCamera;
}
