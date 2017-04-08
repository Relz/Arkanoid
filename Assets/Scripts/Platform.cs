using UnityEngine;

public class Platform : MonoBehaviour 
{
	void Start()
	{
		m_renderer = gameObject.GetComponent<Renderer>();
		m_renderer.material.color = Constant.PLATFORM.COLORS[hp - 1];
		m_source = gameObject.GetComponent<AudioSource>();
	}

	void OnCollisionEnter(Collision col)
	{
		hp -= Racket.GetStrength();
		if (hp <= 0)
		{
			Score.AddScore(Constant.REWARD.DESTROY_PLATFORM);
			m_source.PlayOneShot(explosionSound);
			gameObject.transform.Translate(new Vector3(1000, 1000, 1000));
			Destroy(gameObject, explosionSound.length);
		}
		else
		{
			Score.AddScore(Constant.REWARD.TOUCH_PLATFORM);
			m_source.PlayOneShot(touchSound);
			m_renderer.material.color = Constant.PLATFORM.COLORS[hp - 1];
		}
	}

	public AudioClip touchSound;
	public AudioClip explosionSound;
	private AudioSource m_source;
	private Renderer m_renderer;
	public int hp = 3;
}
