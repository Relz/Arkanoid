using System;

public static class Maps
{
	public static bool[,] GetRandomMap()
	{
		int rowCount = MAPS.GetLength(1);
		int colCount = MAPS.GetLength(2);
		bool [,] result = new bool[rowCount, colCount];
		int mapIndex = new Random().Next(0, MAPS.GetLength(0));
		for (int row = 0; row < rowCount; ++row)
		{
			for (int col = 0; col < colCount; ++col)
			{
				result[row, col] = MAPS[mapIndex, row, col];
			}
		}
		return result;
	}

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
