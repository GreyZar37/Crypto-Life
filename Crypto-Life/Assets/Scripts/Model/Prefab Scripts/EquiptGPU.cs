using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquiptGPU : MonoBehaviour
{
    public GameObject playerInventory;
    public GameObject rackInventory;

    // Start is called before the first frame update
    private void Awake()
    {
        playerInventory = GameObject.FindGameObjectWithTag("PlayerInventory");
        rackInventory = GameObject.FindGameObjectWithTag("StoragePanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openPlayerInventory()
    {
        playerInventory.transform.GetChild(0).gameObject.SetActive(true);
        rackInventory.SetActive(false);
    }
  
}
