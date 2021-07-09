using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ServerRackItem : MonoBehaviour
{

    public TextMeshProUGUI priceText, rackNameText, storageAmountText;
    public Image rackImage;
    public Button button;

   

    ServerRack serverRack;

    private void Start()
    {
        
    }

    public void initialize(ServerRack data)
    {
        serverRack = data;
        priceText.text = string.Format("Buy(${0})", serverRack.price);
        rackNameText.text = string.Format("Rack: {0}", serverRack.name);
        storageAmountText.text = string.Format("Storage: {0}", serverRack.slots);
        rackImage.sprite = serverRack.icon;
        button.onClick.AddListener(onClick);

    }

    void onClick()
    {
        // TODO Optimere dette senere

        GameObject.FindObjectOfType<PlacementScript>().placementInfo(serverRack);

        if (PlacementScript.buildMode == false)
        {
            PlacementScript.buildMode = true;
           serverRack.rackBlueprintPrefab.SetActive(true);
            Instantiate(serverRack.rackBlueprintPrefab);
        }
        else if (PlacementScript.buildMode == true)
        {
            Destroy(GameObject.FindWithTag("Blueprint"));
            PlacementScript.buildMode = false;
        }
    }
}
