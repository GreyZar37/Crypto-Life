using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RackInventory : MonoBehaviour
{

    public GameObject refToPlayerInventory;

    // Start is called before the first frame update
    void Start()
    {
        refToPlayerInventory = GameObject.FindGameObjectWithTag("PlayerInventory");
       

    }

    // Update is called once per frame
    void Update()
    {
       
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
    public void loadData(ObjectStats data)
    {
        
    }
}
