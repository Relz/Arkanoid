using UnityEngine;

public class Level : MonoBehaviour
{
	void Start()
	{
		int mapIndex = new System.Random().Next(0, MAPS.GetLength(0));

		float halfCameraHeight = Camera.main.orthographicSize;
		float halfCameraWidth = Camera.main.orthographicSize * Camera.main.aspect;
		
		float platformOffsetLeft = 0.1f;
		float platformOffsetTop = 0.1f;
		float platformMarginLeft = 0.1f;
		float platformMarginTop = 0.1f;
		
		int rowCount = MAPS.GetLength(1);
		int colCount = MAPS.GetLength(2);
		for (int row = 0; row < rowCount; ++row)
		{
			for (int col = 0; col < colCount; ++col)
			{
				if (MAPS[mapIndex, row, col])
				{
					float racketWidth = platform.localScale.x;
					float halfRacketWidth = racketWidth / 2;
					float racketHeight = platform.localScale.y;
					float halfRacketHeight = racketWidth / 2;
					Instantiate(
						platform, 
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

	public Transform platform;

	private static bool[,,] MAPS = 
	{
		{
			{
				false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false
			}, 
			{
				false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false
			},
			{
				false, true, true, true, true, true, false, false, true, true, true, true, true, false, false, true, true, true, true, true, false, false, true, true, true, true, true, false
			},
			{
				false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false
			},
			{
				false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false
			},
			{
				false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false
			},
			{
				false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false
			},
			{
				false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false
			},
			{
				false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false
			}
		},
		{
			{
				false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false
			}, 
			{
				false, false, false, false, false, false, false, true, true, true, true, true, false, false, false, false, true, true, true, true, true, false, false, false, false, false, false, false 
			},
			{
				false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false
			},
			{
				false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false 
			},
			{
				false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false 
			},
			{
				false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false
			},
			{
				false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false
			},
			{
				false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false
			},
			{
				false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false 
			}
		}
	};
}
