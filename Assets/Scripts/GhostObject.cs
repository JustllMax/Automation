using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GhostObject : MonoBehaviour
{
    [SerializeField] Color placeable, nonPlaceable;
    [SerializeField] Tilemap targetTileMap;
    [SerializeField] Transform anchorPoint;
    [SerializeField] GameObject P_Building;
    
    SpriteRenderer spriteRenderer;
    bool canPlaceObject = true;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = placeable;
        targetTileMap = GridManager.Instance.GetTileMap();
    }
    void Update()
    {

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = new Vector3(worldPos.x, worldPos.y, 0);

        Vector3Int gridPos = targetTileMap.WorldToCell(worldPos);

        if (GridManager.Instance.GetBaseGrid().GetTile(gridPos.x, gridPos.y, out NodeTile tile) != false)
        {
            transform.position = new Vector3(tile.GetX(), tile.GetY(), 0);
        }
        if (Input.GetMouseButtonDown(1) && canPlaceObject)
        {
            Instantiate(P_Building, transform.position, Quaternion.identity);
            //Needs to be added to tilemap
            Debug.Log("Placed");
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision start");
        spriteRenderer.color = nonPlaceable;
        canPlaceObject = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Collision end");
        spriteRenderer.color = placeable;
        canPlaceObject = true;
    }

}
