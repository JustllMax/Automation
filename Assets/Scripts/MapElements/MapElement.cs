using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapElement : MonoBehaviour
{

    public GameObject P_Object;


    public void Spawn(Vector3 p)
    {
        Instantiate(P_Object, p, Quaternion.identity);
    } 
}
