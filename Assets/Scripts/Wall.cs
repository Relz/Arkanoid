using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

	private void Start()
	{
		m_source = gameObject.GetComponent<AudioSource>();
	}
	void OnCollisionEnter(Collision col)
	{
		m_source.PlayOneShot(touchSound);
	}

	public AudioClip touchSound;
	private AudioSource m_source;
}