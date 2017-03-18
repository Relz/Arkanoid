using UnityEngine;

public class GameController : MonoBehaviour 
{	
	public Transform racket;
	void Start()
	{
		bool [,] map = Maps.GetRandomMap();

		float halfCameraHeight = Camera.main.orthographicSize;
		float halfCameraWidth = Camera.main.orthographicSize * Camera.main.aspect;
		float cameraWidth = 2f * halfCameraWidth;

		float platformOffsetLeft = 0.1f;
		float platformOffsetTop = 0.1f;
		float platformMarginLeft = 0.1f;
		float platformMarginTop = 0.1f;
		
		int rowCount = map.GetLength(0);
		int colCount = map.GetLength(1);
		for (int row = 0; row < rowCount; ++row)
		{
			for (int col = 0; col < colCount; ++col)
			{
				if (map[row, col])
				{
					float racketWidth = racket.localScale.x;
					float halfRacketWidth = racketWidth / 2;
					float racketHeight = racket.localScale.y;
					float halfRacketHeight = racketWidth / 2;
					Instantiate(
						racket, 
						new Vector3(
							-halfCameraWidth + halfRacketWidth + (racketWidth + platformMarginLeft) * col + platformOffsetLeft, 
							halfCameraHeight - halfRacketHeight - (racketHeight + platformMarginTop) * row - platformOffsetTop, 
							0
						), 
						Quaternion.identity
					);
				}
			}
		}
	}
	
}
