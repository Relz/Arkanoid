using UnityEngine;

public class Platform : MonoBehaviour 
{
	void OnCollisionEnter(Collision col)
	{
		Debug.Log(gameObject.name);
	}
}
