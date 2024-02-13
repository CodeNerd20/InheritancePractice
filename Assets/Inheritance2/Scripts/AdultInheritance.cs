using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdultInheritance : ControllableCreature
{
    protected override void Interact()
    {
        if (interactable is AdultInteractable)
        {
            Debug.Log("Adults are taking over");
            interactable.Activate();
        }
    }
}
