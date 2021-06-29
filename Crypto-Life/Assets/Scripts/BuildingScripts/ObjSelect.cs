using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSelect : MonoBehaviour
{

    public GameObject inventorylvl1Prefab;
    GameObject thisInventorylvl1;
    // Start is called before the first frame update
    void Start()
    {
        thisInventorylvl1 = (GameObject)Instantiate(inventorylvl1Prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        thisInventorylvl1.transform.GetChild(0).gameObject.SetActive(true);
        thisInventorylvl1.tag = ("ActiveRack");
    }
   
    

}
