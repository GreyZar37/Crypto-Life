using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewServerRackUI : MonoBehaviour
{
    public Transform target;
   public GameObject uiPrefab;


    // Start is called before the first frame update
    void Start()
    {
        EquipmentController equipmentController = FindObjectOfType<EquipmentController>();

        for (int i = 0; i < equipmentController.serverRacks.Count; i++)
        {
            GameObject item = Instantiate(uiPrefab, target);
            item.GetComponent<ServerRackItem>().initialize(equipmentController.serverRacks[i]);
        }
    }

}
