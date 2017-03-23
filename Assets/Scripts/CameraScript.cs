using UnityEngine;

public class CameraScript : MonoBehaviour 
{
	void Update()
	{
		Vector3 position = gameObject.transform.position;
		Quaternion rotation = gameObject.transform.rotation;
		position.x = racket.transform.position.x / 10;
		position.y = ball.transform.position.y / 10;
		rotation.y = -position.x / 20;
		rotation.x = position.y / 10;
		gameObject.transform.position = position;
		gameObject.transform.rotation = rotation;
	}

	public GameObject racket;
	public GameObject ball;
}
