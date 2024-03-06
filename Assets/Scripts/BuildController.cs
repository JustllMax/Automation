using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildController : MonoBehaviour
{

    Tilemap targetTileMap;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) == true)
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int gridPos = targetTileMap.WorldToCell(worldPos);
            GridManager.Instance.GetBaseGrid().GetTile(gridPos.x, gridPos.y);
        }
    }
}
