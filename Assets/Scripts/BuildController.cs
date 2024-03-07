using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildController : MonoBehaviour
{
    [SerializeField]
    Tilemap targetTileMap;

    private void Start()    
    {
 
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0) == true)
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int gridPos = targetTileMap.WorldToCell(worldPos);
            
            if (GridManager.Instance.GetBaseGrid().GetTile(gridPos.x,gridPos.y, out NodeTile tile ) != false)
            {
                Debug.Log(tile.GetTileID());

            }
        }
    }
}
