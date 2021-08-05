using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ServerRack : Equipment
{
    public List<Equipment> equipment;


    public int slots;
    public GameObject rackPrefab;
    public GameObject rackBlueprintPrefab;

    public ServerRack(string name, float price, int id, Sprite icon, int slots, GameObject rackPrefab, GameObject rackBlueprintPrefab) : base(name, price, id, icon)
    {
        this.slots = slots;
        this.rackPrefab = rackPrefab;
        this.rackBlueprintPrefab = rackBlueprintPrefab;
        equipment = new List<Equipment>();
    }

}
