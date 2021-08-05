using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RackStats : MonoBehaviour
{
    public float income;
    public float heatProduction;
    public float powerUsage;

    public int slots;


    private void Awake()
    {
        slots = ServerRackItem.slots;
        print(slots);
    }
}
