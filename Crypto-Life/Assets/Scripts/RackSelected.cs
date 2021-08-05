using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RackSelected : MonoBehaviour
{

    public GameObject rackInventory;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.tag == "Rack")
                {
                    if (EventSystem.current.IsPointerOverGameObject())
                    {
                        return;
                    }

                    else
                    {
                        rackInventory = hit.transform.gameObject;
                        rackInventory.transform.GetChild(0).gameObject.SetActive(true);

                    }

                }

            }

        }
    }

}

    
