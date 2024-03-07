using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class GridManager : MonoBehaviour
{

    public static GridManager Instance;

    [SerializeField ]
    Tilemap tilemap;
    [SerializeField]
    BaseGrid grid;

    private void Awake()
    {
        grid = GetComponent<BaseGrid>();
        tilemap = GetComponentInChildren<Tilemap>();
        Instance = this;
        grid.Init(20, 20);
    }
    
    public BaseGrid GetBaseGrid()
    {
        return grid;
    }

    public Tilemap GetTileMap(){ return tilemap; }
}
    