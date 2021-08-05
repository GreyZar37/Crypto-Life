using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Equipment 
{
    public string name;
    public float price;
    public int id;
    public Sprite icon;

    public Equipment(string name, float price, int id, Sprite icon)
    {
        this.name = name;
        this.price = price;
        this.id = id;
        this.icon = icon;

    }


}
