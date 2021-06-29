using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public GameObject refToRack;

    public Sprite[] gpuSprites;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        refToRack = GameObject.FindGameObjectWithTag("ActiveRack");

       
    }

   public void equipGpuLvl1()
    {
        refToRack.GetComponent<RackInventory>().equipGpuSlotOne(gpuSprites[0], "gpuLvlOne");
        refToRack.transform.GetChild(0).gameObject.SetActive(false);
        refToRack.tag = "Untagged";
    }
    public void equipGpuLvl2()
    {
        refToRack.GetComponent<RackInventory>().equipGpuSlotOne(gpuSprites[1], "gpuLvlTwo");
        refToRack.transform.GetChild(0).gameObject.SetActive(false);
        refToRack.tag = "Untagged";
    }
    public void leavePlayerinventory()
    {
        refToRack.transform.GetChild(0).gameObject.SetActive(false);
        refToRack.tag = "Untagged";
    }
}
