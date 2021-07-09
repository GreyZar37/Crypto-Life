using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementScript : MonoBehaviour
{

   [Header("Position")]
    public Vector3 placePosition;
    public static float rotation;

    public RaycastHit hitPosition;

    [Header("Placement")]
    public static bool buildMode;
    public static bool canPlace = true;

    [Header("Prefabs")]
    public GameObject[] allRacksInScene;

    ServerRack currentRackPrefab;

    // Update is called once per frame
    void Update()
    {

     
        placementFunction();


    }

    public void placementFunction()
    {

        if (buildMode == true)
        {
            allRacksInScene = GameObject.FindGameObjectsWithTag("Rack");
            foreach (GameObject table in allRacksInScene)
            {
                table.layer = 2;
            }
        }
        else if (buildMode == false)
        {
            allRacksInScene = GameObject.FindGameObjectsWithTag("Rack");
            foreach (GameObject table in allRacksInScene)
            {
                table.layer = 0;
            }
        }




        if (Input.GetKeyDown(KeyCode.R) && rotation == 0)
        {
            rotation = 90f;
        }
        else if (Input.GetKeyDown(KeyCode.R) && rotation == 90)
        {
            rotation = 0f;
        }

        if (Input.GetMouseButtonDown(0) && buildMode == true)
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitPosition))
            {
                if (hitPosition.transform.tag == "Floor")
                {
                    placePosition = hitPosition.point;
                    if (canPlace == true)
                    {
                        Instantiate(currentRackPrefab.rackPrefab, placePosition, Quaternion.Euler(0f, rotation, 0f));
                        buildMode = false;
                    }

                }

            }
        }
    }
    public void placementInfo(ServerRack data)
    {
        currentRackPrefab = data;
    }
}
