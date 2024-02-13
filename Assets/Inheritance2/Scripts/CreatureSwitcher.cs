using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CreatureSwitcher : MonoBehaviour
{

    public ControllableCreature[] creatures;
    public int index = 0;
    public int max;
    public CinemachineVirtualCamera vCam;


    // Start is called before the first frame update
    void Start()
    {
        creatures = GameObject.FindObjectsOfType<ControllableCreature>();
        index = 0;
        max = creatures.Length;
        UpdateControl();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            UpdateControl();
        }
    }

    private void UpdateControl()
    {
        index++;
        if(index == max)
        {
            index = 0;
        }
        //clear the control
        foreach(ControllableCreature currentCreature in creatures)
        {
            currentCreature.isControlled = false;
        }
        ControllableCreature creature = creatures[index];
        creature.isControlled = true;
        vCam.Follow = creature.gameObject.transform;
        vCam.LookAt = creature.gameObject.transform;
    }
}
