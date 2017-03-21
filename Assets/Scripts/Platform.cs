using UnityEngine;

public class Platform : MonoBehaviour 
{
	void Start()
	{
		m_renderer = gameObject.GetComponent<Renderer>();
		m_renderer.material.color = Constant.PLATFORM.COLORS[hp - 1];
	}

	void OnCollisionEnter(Collision col)
	{
		hp -= Racket.GetStrength();
		if (hp <= 0)
		{
			Destroy(gameObject);
		}
		else
		{
			m_renderer.material.color = Constant.PLATFORM.COLORS[hp - 1];
		}
	}

	private Renderer m_renderer;
	public int hp = 3;
}
