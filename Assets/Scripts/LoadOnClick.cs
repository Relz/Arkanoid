using System.Collections;
using UnityEngine;

public class LoadOnClick : MonoBehaviour
{
	public void OnLoadLevel(int level)
	{
		Level.SetLevel(level);
		Application.LoadLevel(1);
	}
	public void OnLoadRandomLevel()
	{
		Application.LoadLevel(1);
	}
}
