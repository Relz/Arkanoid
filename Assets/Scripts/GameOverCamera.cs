using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCamera : MonoBehaviour
{
	private void Start()
	{
		gameOverCamera = gameObject.GetComponent<Camera>();
	}

	void Update()
	{

	}
	public static void SetActive(bool value)
	{
		gameOverCamera.enabled = value;
	}

	private static Camera gameOverCamera;
}
