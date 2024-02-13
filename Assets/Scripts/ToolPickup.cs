using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolPickup : Pickup
{
    public GameObject toolPrefab;

    protected override void ActivatePickup()
    {
        ToolControl tc = GameObject.FindObjectOfType<ToolControl>();
        if(tc == null)
        {
            Debug.Log("No tool slot found");
        }
        else
        {
            tc.UpdateTool(toolPrefab); 
        }
    }
}
