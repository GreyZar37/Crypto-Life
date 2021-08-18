using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RackSelected : MonoBehaviour
{
    GameObject refToRack;
    GameObject EquipButton;

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

                if (hit.collider.tag == "EquipButton")
                {
                    EquipButton = hit.transform.gameObject;
                    print(EquipButton.name);

                }
                


                else if (hit.transform.tag == "Rack")
                {
                    if (EventSystem.current.IsPointerOverGameObject())
                    {
                        return;

                    }

                    else
                    {
                        refToRack = hit.transform.gameObject;
                        refToRack.GetComponent<RackInventoryCreator>().refRackInventory.transform.GetChild(0).gameObject.SetActive(true);

                    }

                }

            }

        }


    }

   

}
