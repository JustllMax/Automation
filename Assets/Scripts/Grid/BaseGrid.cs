using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BaseGrid : MonoBehaviour
{

    int gridHeight, gridWidth;
    float cellSizeX, cellSizeY;
    float anchorX, anchorY;
    List<List<NodeTile>> nodeTileGrid;
    [SerializeField]
    MapElement el;

    float xPos, yPos;
    public void Init(int h, int w, float csx, float csy, float ax, float ay)
    {
        gridHeight = h;
        gridWidth = w;
        cellSizeX = csx;
        cellSizeY = csy;   
        anchorX = ax; 
        anchorY = ay;

        CreateGrid();
    }

    private void CreateGrid()
    {
        nodeTileGrid = new List<List<NodeTile>>();
        xPos = 0;
        yPos = 0;
        for (int i = 0; i < gridWidth; i++)
        {
            nodeTileGrid.Add(new List<NodeTile>());
            for (int j = 0; j < gridHeight; j++)
            {

                nodeTileGrid[i].Add(new NodeTile(xPos + anchorX, yPos + anchorY));
                nodeTileGrid[i][j].SetMapElement(el);
                Debug.Log(nodeTileGrid[i][j].GetTileID());
                xPos += cellSizeX;
            }
            xPos = 0; yPos += cellSizeY;
        }
    }

    public void SetTile(int x, int y, NodeTile tile)
    {
        nodeTileGrid[x][y] = tile;
        
    }

    public bool GetTile(int x, int y, out NodeTile tile) 
    {
       
        if (CheckPosition(x, y) == false) 
        { 
            tile = null;
            return false;
        }

        tile = nodeTileGrid[x][y];
        return true;
    }


    bool CheckPosition(int x, int y)
    {
        if( x < 0 || x >= gridWidth) return false;
        if( y < 0 || y >= gridHeight) return false;
        return true;
    }
}
