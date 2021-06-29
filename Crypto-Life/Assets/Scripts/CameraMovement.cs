using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform cameraTransform;

    public float cameraMovementSpeed;
    public float smoother;
    public float scrollSpeed;

    float rightMaxPosition = 10;
    float leftMaxPosition = 3f;

     float upPositionMax = 13f;
     float downPositionMax = 8f;
    
    

    public Vector3 newCameraPosition;

    private Camera cameraZoom;
    

    // Start is called before the first frame update
    void Start()
    {
        cameraZoom = Camera.main;
        newCameraPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        HandleCameraMovement();
    }
    void HandleCameraMovement()
    {

       
        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
           
            if (newCameraPosition.y <= upPositionMax)
            {
                newCameraPosition += (transform.up * cameraMovementSpeed);
            }
          
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if (newCameraPosition.y >= downPositionMax)
            {
                newCameraPosition += (transform.up * -cameraMovementSpeed);
            }
       
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (newCameraPosition.x <= rightMaxPosition)
            {
                newCameraPosition += (transform.right * cameraMovementSpeed);
            }
            
            
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow))
        {
            if(newCameraPosition.x >= leftMaxPosition)
            {
                newCameraPosition += (transform.right * -cameraMovementSpeed);
            }
          
            
        }

       



        cameraZoom.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;

        if (cameraZoom.orthographicSize >= 9)
        {
            cameraZoom.orthographicSize = 9;
        }
       

        if (cameraZoom.orthographicSize <= 4)
        {
            cameraZoom.orthographicSize = 4;
        }


    
        transform.position = Vector3.Lerp(transform.position, newCameraPosition, Time.deltaTime * smoother);
        

    }
}
