using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class MinerEquipment : Equipment
{

    public float income;
    public float heatProduction;
    public float powerUsage;
    public int amount;

    public MinerEquipment(string name, float price, int id, Sprite icon, float income, float heatProduction, float powerUsage, int amount): base(name, price, id, icon)
    {
        this.income = income;
        this.heatProduction = heatProduction;
        this.powerUsage = powerUsage;
        this.amount = amount;

    }

}
