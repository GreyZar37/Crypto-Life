using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjSelect : MonoBehaviour
{

    public GameObject inventorylvl1;
  

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
                        inventorylvl1.transform.GetChild(0).gameObject.SetActive(true);

                        Transform g = hit.transform;
                        print(g.name);
                        ObjectStats t = g.GetComponent<ObjectStats>();
                        print("T NULL: " + (t == null));

                        print("T TYPE: " + t.GetType());
                        inventorylvl1.GetComponent<RackInventory>().loadData(t);
                    }
                    
                }
  
            }

        }
    }
}
