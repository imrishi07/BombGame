using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawner : MonoBehaviour
{
  public Tilemap tilemap;
  public Tile wallTile;

  public GameObject bombPrefab;

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      //Debug.Log("worldPos " + worldPos);
      Vector3Int cell = tilemap.WorldToCell(worldPos);
      //Debug.Log("cell " + cell);
      Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);

      Tile tile = tilemap.GetTile<Tile>(cell);
      if (tile != wallTile)
      {
        Instantiate(bombPrefab, cellCenterPos, Quaternion.identity);
      }

    }
  }
}
