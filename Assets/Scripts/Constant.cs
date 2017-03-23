using UnityEngine;
public static class Constant 
{
	public const float RACKET_SPEED = 0.7f;
	public const float BALL_SPEED = 0.3f;
	public const float BALL_SPEED_MULTIPLIER = 2600; // Для единой системы скорости BALL_SPEED и RACKET_SPEED

	public static class PLATFORM
	{
		public const int HP = 3;
		public static Color[] COLORS = new Color[HP] 
		{
			Color.red,
			Color.blue,
			Color.green
		};
	}

	public static class MAP
	{
		public const string PATH = "Maps/";
		public const string NAME_PREFIX = "map";
		public const char PLATFORM_CHAR = '#';
	}
}
