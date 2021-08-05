using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewGpuSlot : MonoBehaviour
{

    public Transform target;
    public int slots;

    public GameObject uiPrefab;

    

    // Start is called before the first frame update
    void Start()
    {


        

        for (int i = 0; i < slots; i++)
        {
            Instantiate(uiPrefab, target);
            
        }
    }
   

    



}
