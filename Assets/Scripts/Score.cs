using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	void Start ()
	{
		m_scoreValueText = scoreValueObj.GetComponent<Text>();
	}

	public static void AddScore(int value)
	{
		m_score += value;
		m_scoreValueText.text = m_score.ToString();
	}

	public GameObject scoreValueObj;
	private static Text m_scoreValueText;
	private static int m_score;
}
