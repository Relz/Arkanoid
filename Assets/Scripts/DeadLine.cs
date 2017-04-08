using UnityEngine;

public class DeadLine : MonoBehaviour 
{
	void OnCollisionEnter(Collision col)
	{
		Racket.DecrementLives();
		if (Racket.GetLives() == 0)
		{
			GameCamera.SetActive(false);
			GameOverCamera.SetActive(true);
		}
		Ball.Reset();
		Racket.Reset();
	}
}
