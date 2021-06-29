using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RackInventory : MonoBehaviour
{

    public GameObject refToPlayerInventory;

    public Button slotOne;

    public float income;
    public float devPrSecond;

    // Start is called before the first frame update
    void Start()
    {
        refToPlayerInventory = GameObject.FindGameObjectWithTag("PlayerInventory");
       

    }

    // Update is called once per frame
    void Update()
    {
        income += Time.deltaTime * devPrSecond;
        print(income);
    }

    public void equipGpuSlotOne(Sprite sprite, string gpu_name)
    {
        slotOne.image.sprite = sprite;
        switch (gpu_name)
        {
            case "gpuLvlOne":
                devPrSecond = 1;
                break;
            case "gpuLvlTwo":
                devPrSecond = 3;
                break;
            default:
                break;
        }
    }
    public void openPlayerInventory()
    {
        refToPlayerInventory.SetActive(true);
        refToPlayerInventory.transform.GetChild(0).gameObject.SetActive(true);
    }
    public void leaveRack()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.tag = "Untagged";
    }
}
