using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RackInventoryCreator : MonoBehaviour
{
    public GameObject rackInventory;
    [SerializeField]
    public GameObject refRackInventory;

    private void Awake()
    {
        refRackInventory = Instantiate(rackInventory);

        refRackInventory.GetComponent<CreateNewGpuSlot>().slots = GetComponent<RackStats>().slots;
    }

   
}
