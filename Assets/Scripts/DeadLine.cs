using UnityEngine;

public class DeadLine : MonoBehaviour 
{
	void OnCollisionEnter(Collision col)
	{
		Ball.Reset();
		Racket.Reset();
	}
}
