using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;

public class Level : MonoBehaviour
{
	void Start()
	{
		List<List<List<bool>>> maps = ReadMaps();
		int mapIndex = 0;
		mapIndex = (m_level == int.MaxValue) ? mapIndex = new System.Random().Next(0, maps.Count) : m_level - 1;

		float halfCameraHeight = Camera.main.orthographicSize;
		float halfCameraWidth = Camera.main.orthographicSize * Camera.main.aspect;
		
		float platformOffsetLeft = 0.1f;
		float platformOffsetTop = 0.1f;
		float platformMarginLeft = 0.1f;
		float platformMarginTop = 0.1f;
		
		int rowCount = maps[mapIndex].Count;
		int colCount = maps[mapIndex][0].Count;
		for (int row = 0; row < rowCount; ++row)
		{
			for (int col = 0; col < colCount; ++col)
			{
				if (maps[mapIndex][row][col])
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

	private static List<List<List<bool>>> ReadMaps()
	{
		List<List<List<bool>>> result = new List<List<List<bool>>>();
		uint mapIndex = 0;
		while (true)
		{
			try
			{
				String[] lines = File.ReadAllLines(Constant.MAP.PATH + Constant.MAP.NAME_PREFIX + mapIndex);
				if (lines.Length != 0)
				{
					result.Add(new List<List<bool>>());
				}
				for (int i = 0; i < lines.Length; ++i)
				{
					result[result.Count - 1].Add(new List<bool>());
					for (int j = 0; j < lines[i].Length; ++j)
					{
						result[result.Count - 1][i].Add(lines[i][j] == Constant.MAP.PLATFORM_CHAR);
					}
				}
				++mapIndex;
			}
			catch (Exception e)
			{
				break;
			}
		}
		return result;
	}

	public static void SetLevel(int value)
	{
		m_level = value;
	}

	public Transform platform;
	private static int m_level = int.MaxValue;
}
