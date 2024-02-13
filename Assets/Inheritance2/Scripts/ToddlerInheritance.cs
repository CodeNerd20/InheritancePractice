using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToddlerInheritance : ControllableCreature
{
    protected override void Interact()
    {
        if (interactable is ToddlerInteractable)
        {
            Debug.Log("Fight the parents");
            interactable.Activate();
        }
        else
        {
            Debug.Log("ew. Grown up stuff");
        }
    }
}
