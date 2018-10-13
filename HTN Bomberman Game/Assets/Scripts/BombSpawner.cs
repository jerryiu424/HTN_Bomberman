using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawner : MonoBehaviour {

    public Tilemap tilemap;

    public GameObject bombprefab;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cell = tilemap.WorldToCell(worldpos);
            Vector3 CellCenterPos = tilemap.GetCellCenterWorld(cell);

            Instantiate(bombprefab, CellCenterPos, Quaternion.identity);
        }
	}
}
