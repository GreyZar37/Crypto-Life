using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
                        refToRack = hit.transform.gameObject;
                    }

                }

            }

        }


    }

    public void gpuLvlOne()
    {
        print("GPU");
        refToRack.GetComponent<ObjectStats>().equipGpuSlotOne(gpuSprites[0], "gpuLvlOne");
       
    }
    public void gpuLvlTwo()
    {
        refToRack.GetComponent<ObjectStats>().equipGpuSlotOne(gpuSprites[1], "gpuLvlTwo");

    }

}
