using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonGrid : MonoBehaviour {
	[SerializeField]
	private int width = 6;
	[SerializeField]
	private int height = 6;
	[SerializeField]
	private HexCell cellPrefab;
	HexCell[] cells;
	HexMesh mesh;

	void Awake () {
		mesh = GetComponentInChildren<HexMesh>();
		cells = new HexCell[height * width];
		for (int z = 0, i = 0; z < height; z++) {
			for (int x = 0; x < height; x++) {
				CreateHex (z, x, i++);
			}
		}
	}
	void Start(){
		mesh.Triangulate (cells);
	}
	
	void CreateHex (int x, int z, int i){
		Vector3 position;
		position.x = (x + z * 0.5f - z/2) * (HexMetrics.RadiusIn * 3f);
		position.y = 0f;
		position.z = z * (HexMetrics.RadiusOut * 1.5f);

		HexCell cell = cells [i] = Instantiate<HexCell> (cellPrefab);
		cell.transform.SetParent (transform, false);
		cell.transform.localPosition = position;
	}
}

