using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildController : MonoBehaviour
{
    
    [SerializeField]
    GameObject P_GhostObj;
    private void Start()    
    {
 
    }

    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(P_GhostObj);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
          
        }
    }
}
