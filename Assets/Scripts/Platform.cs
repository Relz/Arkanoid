using UnityEngine;

public class Platform : MonoBehaviour 
{
	void Start()
	{
		m_renderer = gameObject.GetComponent<Renderer>();
				m_renderer.material.color = new Color(1, 0, 0, 1);
	}

	void OnCollisionEnter(Collision col)
	{
		--hp;
		switch (hp)
		{
			case 2:
				m_renderer.material.color = new Color(0, 1, 0, 1);
				break;
			case 1:
				m_renderer.material.color = new Color(0, 0, 1, 1);
				break;
			case 0:
				Destroy(gameObject);
				break;
		}
	}

	private Renderer m_renderer;
	public uint hp = 3;
}
