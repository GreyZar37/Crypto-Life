using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePrintScript : MonoBehaviour
{

    [Header("Position")]
    public RaycastHit hitPosition;
    public Material material;

    public Vector3 mousePosition;
    public Vector3 mousePositionOffset;



    [Header("Colors")]
    public Color redColor;
    public Color greenColor;


     // Start is called before the first frame update
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && PlacementScript.canPlace == true)
        {
            Destroy(gameObject);
        }
        


        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitPosition))
        {
          
                if (hitPosition.transform.tag == "Floor")
                {
                transform.position = hitPosition.point;
                transform.rotation = Quaternion.Euler(0, PlacementScript.rotation, 0);
                if (PlacementScript.canPlace == true)
                {
                    material.color = greenColor;
                }
     
                }
                else
                {
                transform.position = hitPosition.point;
                transform.rotation = Quaternion.Euler(0, PlacementScript.rotation, 0);
                material.color = redColor;
                    PlacementScript.canPlace = false;
                }

        }
        else
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,8f));
            transform.position = mousePosition;
            transform.rotation = Quaternion.Euler(0, PlacementScript.rotation, 0);
            material.color = redColor;
            PlacementScript.canPlace = false;
        }
            

       
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Rack" || collision.gameObject.tag == "Wall")
        {
            material.color = redColor;
            PlacementScript.canPlace = false;
        }
    }
    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Rack" || collision.gameObject.tag == "Wall")
        {
            PlacementScript.canPlace = true;
            material.color = greenColor;
        }


    }
}
