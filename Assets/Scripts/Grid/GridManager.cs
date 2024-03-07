using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class GridManager : MonoBehaviour
{

    public static GridManager Instance;


    Tilemap tilemap;
    BaseGrid grid;

    [Header("Grid options")]
    [SerializeField] int gridHeight;
    [SerializeField] int gridWidth;
    [SerializeField] float cellSizeX, cellSizeY;
    [SerializeField] float anchorX, anchorY;
    private void Awake()
    {
        grid = GetComponent<BaseGrid>();
        tilemap = GetComponentInChildren<Tilemap>();
        Instance = this;
        grid.Init(gridHeight, gridWidth, cellSizeX, cellSizeY, anchorX, anchorY);
    }
    
    public BaseGrid GetBaseGrid()
    {
        return grid;
    }

    public Tilemap GetTileMap(){ return tilemap; }
}
    