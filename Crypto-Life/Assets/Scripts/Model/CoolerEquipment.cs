using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CoolerEquipment : Equipment
{

    public float powerUsage;
    public float heatReduction;

    public CoolerEquipment(string name, float price, int id, Sprite icon, float powerUsage, float heatReduction) : base(name, price, id, icon)
    {
        this.powerUsage = powerUsage;
        this.heatReduction = heatReduction;
    }
}
