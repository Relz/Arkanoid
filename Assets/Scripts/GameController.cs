using UnityEngine;

public class GameController : MonoBehaviour 
{
	void Start()
	{
		bool [,] map = Maps.GetRandomMap();
		
		int rowCount = map.GetLength(0);
		int colCount = map.GetLength(1);
		for (int row = 0; row < rowCount; ++row)
		{
			for (int col = 0; col < colCount; ++col)
			{
				Debug.Log(map[row, col]);
			}
		}
	}
	
}
