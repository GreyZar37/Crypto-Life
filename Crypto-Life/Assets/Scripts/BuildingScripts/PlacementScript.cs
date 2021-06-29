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
    public bool buildMode;
    public static bool canPlace = true;

    [Header("Prefabs")]

    public GameObject[] tabelprefabs;
    public GameObject[] tabelprefabsBlueprints;

    public GameObject[] allTablesInScene;

    string tableName;
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(buildMode == true)
        {
            allTablesInScene = GameObject.FindGameObjectsWithTag("Table");
            foreach (GameObject table in allTablesInScene)
            {
                table.layer = 2;
            }
        }
        else if(buildMode == false)
        {
            allTablesInScene = GameObject.FindGameObjectsWithTag("Table");
            foreach (GameObject table in allTablesInScene)
            {
                table.layer = 0;
            }
        }
        



        if (Input.GetKeyDown(KeyCode.R) && rotation == 0)
        {
            rotation = 90f;
        }
        else if(Input.GetKeyDown(KeyCode.R) && rotation == 90)
        {
            rotation = 0f;
        }

        if (Input.GetMouseButtonDown(0) && buildMode ==  true)
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hitPosition))
            {
                if(hitPosition.transform.tag == "Floor")
                {
                    placePosition = hitPosition.point;
                    if(canPlace == true)
                    {
                        switch (tableName)
                        {
                            case "Table1":
                                Instantiate(tabelprefabs[0], placePosition, Quaternion.Euler(0f, rotation, 0f));
                                tabelprefabsBlueprints[0].SetActive(false);
                                buildMode = false;
                                break;

                            case "Table2":
                                Instantiate(tabelprefabs[1], placePosition, Quaternion.Euler(0f, rotation, 0f));
                                tabelprefabsBlueprints[1].SetActive(false);
                                buildMode = false;
                                break;
                            
                            default:
                                break;
                        }
                      
                        
                    }
                         
                }

            }
        }
       
    }
    public void placeTabel()
    {
        tableName = "Table1";
        if(buildMode == false)
        {
            buildMode = true;
            tabelprefabsBlueprints[0].SetActive(true);
            Instantiate(tabelprefabsBlueprints[0]);
        }
        else if(buildMode == true)
        {
            Destroy(GameObject.FindWithTag("Blueprint"));
            buildMode = false;
        }
      
    }
    public void placeTabel2()
    {
        tableName = "Table2";
        if (buildMode == false)
        {
            buildMode = true;
            tabelprefabsBlueprints[1].SetActive(true);
            Instantiate(tabelprefabsBlueprints[1]);
            
        }
        else if (buildMode == true)
        {
            Destroy(GameObject.FindWithTag("Blueprint"));
            buildMode = false;
        }
    }
}
