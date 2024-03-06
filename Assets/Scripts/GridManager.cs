using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class GridManager : MonoBehaviour
{

    public static GridManager Instance;

    Tilemap tilemap;
    BaseGrid grid;

    private void Start()
    {
        grid = GetComponent<BaseGrid>();
        tilemap = GetComponentInChildren<Tilemap>();

        grid.Init(20, 20);
    }
    
    public BaseGrid GetBaseGrid()
    {
        return grid;
    }
}
    