using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HexMetrics {	
	public const float RadiusOut = 10f;
	public const float RadiusIn = RadiusOut * 0.866025404f;

	public static Vector3[] Vertices = {
		new Vector3(0f, 0f, RadiusOut),
		new Vector3(RadiusIn, 0f, 0.5f * RadiusOut),
		new Vector3(RadiusIn, 0f, -0.5f * RadiusOut),
		new Vector3(0f, 0f, -RadiusOut),
		new Vector3(-RadiusIn, 0f, -0.5f * RadiusOut),
		new Vector3(-RadiusIn, 0f, 0.5f * RadiusOut),
		new Vector3(0f,0f, RadiusOut)
	};
}



