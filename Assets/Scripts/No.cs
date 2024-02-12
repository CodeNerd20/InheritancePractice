using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No : MonoBehaviour
{
    public string noName;
    public float noWeight;
    public float noLength;
    public bool hasEatenDerek;

    public virtual void Nope()
    {
        Debug.Log("No");
    }
}
