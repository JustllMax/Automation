using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeTile
{ 
    float xPos, yPos;
    static int id = 0;
    int tileID;
    MapElement element;
    bool isWalkable;
    public NodeTile(float x, float y)
    {
        tileID = id++; 
        xPos = x;
        yPos = y;
    }

    public int GetTileID () { return tileID; }
    public void SetMapElement(MapElement el) 
    { 
        this.element = el; 
        element.Spawn(new Vector3(xPos, yPos,0));
    }
    public MapElement GetMapElement() { return element; }
    public float GetX () { return xPos; }
    public float GetY () { return yPos; }
}
