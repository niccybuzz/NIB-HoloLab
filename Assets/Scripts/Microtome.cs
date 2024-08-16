using Meta.WitAi;
using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Microtome : SnappablePlatform
{

    public InstructionsPanelManager instructionsManager;
    /* 
     * When a slice is generated by the microtome, this field is required to get the image that will be displayed on the screen
     * Each block is spawned with a random image attached. Doing it this way ensures that every slice that is generated from the block has the same image attached.
    */
    private GameObject mostRecentBlockAttached;

    public GameObject MostRecentBlockAttached { get => mostRecentBlockAttached; set => mostRecentBlockAttached = value; }

    // Called every time a block is attached to the platform. Updates the most recent block attached
    public void AttachBlock()
    {
        mostRecentBlockAttached = GetObjectOnPlatform();
        if (instructionsManager != null)
        {
            instructionsManager.NextPanel(1f);
        }
    }


    // Called whenever a correct match is made in challenge mode. Deletes the block currently on the platform
    public void ClearBlocksOnPlatform()
    {
        mostRecentBlockAttached.SetActive(false);
    }

}
