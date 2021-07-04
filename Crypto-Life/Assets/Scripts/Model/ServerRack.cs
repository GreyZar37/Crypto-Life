using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ServerRack : Equipment
{
    public List<Equipment> equipment;


    public int slots;
    public GameObject rackPrefab;

    public ServerRack(string name, float price, int id, Sprite icon, int slots, GameObject rackPrefab) : base(name, price, id, icon)
    {
        this.slots = slots;
        this.rackPrefab = rackPrefab;
        equipment = new List<Equipment>();
    }

}
