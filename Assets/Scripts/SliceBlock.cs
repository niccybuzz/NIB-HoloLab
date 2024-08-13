using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SliceBlock : MonoBehaviour
{
    public Transform spawnLocation;
    private Vector3 spawnPosition;
    private Quaternion spawnRotation;
    public GameObject slice;
    public InstructionsPanelManager2 instructionsPanel;
    private void Start()
    {
        spawnPosition = spawnLocation.transform.position;
        spawnRotation = spawnLocation.transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("SampleBlock"))
        {
            Instantiate(slice, spawnPosition, spawnRotation);
            if (instructionsPanel != null)
            {
                instructionsPanel.NextPanel(1f);

            }
        }
    }
}