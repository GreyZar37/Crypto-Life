using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentController : MonoBehaviour
{

    [Header("Models")]
    public List<CoolerEquipment> coolers;
    public List<PowerEquipment> powerSources;
    public List<MinerEquipment> miners;
    public List<ServerRack> serverRacks;


    [Header("Icons and Gameobjects")]
    public List<GameObject> rackBlueprintPrefabs;
    public List<GameObject> rackPrefabs;


   
    public List<Sprite> rackIcons;
    public List<Sprite> coolersIcons;
    public List<Sprite> powerSourcesIcons;
    public List<Sprite> gpuSourcesIcons;


    private void Start()
    {
        //Coolers
        coolers = new List<CoolerEquipment>();

        coolers.Add(new CoolerEquipment("R12", 50, coolers.Count, rackIcons[0], 2.5f, 10f));

        //powerSources
        powerSources = new List<PowerEquipment>();

        powerSources.Add(new PowerEquipment("PowerLit", 100, powerSources.Count, rackIcons[0], 10, 0.5f, 50));

        //miners
        miners = new List<MinerEquipment>();

        miners.Add(new MinerEquipment("GX 18", 20, miners.Count, gpuSourcesIcons[0], 0.0001f, 1f, 2, 0));
        miners.Add(new MinerEquipment("GX 32", 100, miners.Count, gpuSourcesIcons[1], 0.0008f, 3f, 4, 0));
        miners.Add(new MinerEquipment("GX 64", 250, miners.Count, gpuSourcesIcons[2], 0.0012f, 5f, 8, 0));

        //serverRacks
        serverRacks = new List<ServerRack>();

        serverRacks.Add(new ServerRack("LT1", 15, serverRacks.Count, rackIcons[0], 1, rackPrefabs[0], rackBlueprintPrefabs[0]));
        serverRacks.Add(new ServerRack("RT2", 100, serverRacks.Count, rackIcons[1], 2, rackPrefabs[1], rackBlueprintPrefabs[1]));

    }


}
