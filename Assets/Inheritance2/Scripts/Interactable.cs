using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public virtual void Activate()
    {
        Debug.Log($"{name} has been activated");
    }
}
