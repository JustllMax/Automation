using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGrid : MonoBehaviour
{
    int height, width;

    NodeTile[,] nodeTileGrid;

    public void Init(int h, int w )
    {
        nodeTileGrid = new NodeTile[h, w];
        height = h; 
        width = w;

        for( int i = 0; i < height; i++ )
        {
            for( int j = 0; j < width; j++)
            {
                nodeTileGrid[i, j] = new NodeTile();
            }
        }
    }

    public void SetTile(int x, int y, NodeTile tile)
    {
        nodeTileGrid[x,y] = tile; 
    }

    public NodeTile GetTile(int x, int y) 
    { 
        if(!CheckPosition(x, y)) return null;

        return nodeTileGrid[x,y];
    }


    bool CheckPosition(int x, int y)
    {
        if( x < 0 || x >= width) return false;
        if( y < 0 || y >= height) return false;
        return true;
    }
}
