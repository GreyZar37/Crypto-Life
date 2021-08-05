using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShopItemsUI : MonoBehaviour
{
   public Transform rackTarget;
   public GameObject rackUiPrefab;

   public Transform minersTarget;
   public GameObject minersUiPrefab;

    /* public Transform powerTarget;
     public GameObject powerUiPrefab;

     public Transform coolerTarget;
     public GameObject coolerUiPrefab; */


    // Start is called before the first frame update
    void Start()
    {
        EquipmentController equipmentController = FindObjectOfType<EquipmentController>();

        for (int i = 0; i < equipmentController.serverRacks.Count; i++)
        {
            GameObject item = Instantiate(rackUiPrefab, rackTarget);
            item.GetComponent<ServerRackItem>().initialize(equipmentController.serverRacks[i]);
        }
        for (int i = 0; i < equipmentController.miners.Count; i++)
        {
            GameObject item = Instantiate(minersUiPrefab, minersTarget);
            item.GetComponent<MinerItem>().initialize(equipmentController.miners[i]);
        }
        /*for (int i = 0; i < equipmentController.powerSources.Count; i++)
        {
            GameObject item = Instantiate(powerUiPrefab, powerTarget);
            item.GetComponent<ServerRackItem>().initialize(equipmentController.serverRacks[i]);
        }
        for (int i = 0; i < equipmentController.coolers.Count; i++)
        {
            GameObject item = Instantiate(coolerUiPrefab, coolerTarget);
            item.GetComponent<ServerRackItem>().initialize(equipmentController.serverRacks[i]);
        }*/
    }

}
