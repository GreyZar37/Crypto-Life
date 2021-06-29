using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjSelect : MonoBehaviour
{

    public GameObject inventorylvl1Prefab;
  

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
                        Debug.DrawLine(ray.origin, hit.point, Color.red, 1);
                        inventorylvl1Prefab.transform.GetChild(0).gameObject.SetActive(true);
                        inventorylvl1Prefab.GetComponent<RackInventory>().loadData(hit.transform.GetComponent<ObjectStats>());
                    }
                    
                }
  
            }

        }
    }
}
