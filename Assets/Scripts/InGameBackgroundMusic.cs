using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameBackgroundMusic : MonoBehaviour
{
	void Start ()
	{
		m_source = gameObject.GetComponent<AudioSource>();
		int backgroundMusicIndex = new System.Random().Next(0, 4);
		switch (backgroundMusicIndex)
		{
			case 0:
				m_source.clip = backgroundMusic0;
				m_source.Play();
				break;
			case 1:
				m_source.clip = backgroundMusic1;
				m_source.Play();
				break;
			case 2:
				m_source.clip = backgroundMusic2;
				m_source.Play();
				break;
			case 3:
				m_source.clip = backgroundMusic3;
				m_source.Play();
				break;
		}
	}

	public AudioClip backgroundMusic0;
	public AudioClip backgroundMusic1;
	public AudioClip backgroundMusic2;
	public AudioClip backgroundMusic3;
	private AudioSource m_source;
}
