using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PowerEquipment : Equipment
{

    public float powerProduction;
    public float heatProduction;
    public float upkeepPrice;

    public PowerEquipment(string name, float price, int id, Sprite icon, float upkeepPrice, float heatProduction, float powerProduction) : base(name, price, id, icon)
    {
        this.powerProduction = powerProduction;
        this.heatProduction = heatProduction;
        this.upkeepPrice = upkeepPrice;
    }

}
