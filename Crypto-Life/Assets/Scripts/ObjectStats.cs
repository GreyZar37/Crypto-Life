using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectStats : MonoBehaviour
{

    public Button slotOne;

    public float Income;
    public float multiplier;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Income += Time.deltaTime * multiplier;
    }

    public void equipGpuSlotOne(Sprite sprite, string gpu_name)
    {
        slotOne.image.sprite = sprite;
        switch (gpu_name)
        {
            case "gpuLvlOne":
                multiplier = 0.0001f;
                break;
            case "gpuLvlTwo":
                multiplier = 0.0004f;
                break;
            default:
                break;
        }
    } 
}
