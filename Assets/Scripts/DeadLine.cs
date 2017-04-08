using UnityEngine;

public class DeadLine : MonoBehaviour 
{
	private void Start()
	{
		m_source = gameObject.GetComponent<AudioSource>();
	}
	void OnCollisionEnter(Collision col)
	{
		m_source.PlayOneShot(sound);
		Racket.DecrementLives();
		if (Racket.GetLives() == 0)
		{
			Application.LoadLevel(0);
		}
		Ball.Reset();
		Racket.Reset();
	}

	public AudioClip sound;
	private AudioSource m_source;
}
