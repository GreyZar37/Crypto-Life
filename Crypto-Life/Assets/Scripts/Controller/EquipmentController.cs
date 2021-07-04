using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentController : MonoBehaviour
{
    public List<CoolerEquipment> coolers;
    public List<PowerEquipment> powerSources;
    public List<MinerEquipment> miners;
    public List<ServerRack> serverRacks;

    public Sprite icon;
    public GameObject rackPrefab;

    private void Start()
    {
        //Coolers
        coolers = new List<CoolerEquipment>();

        coolers.Add(new CoolerEquipment("R12", 50, coolers.Count, icon, 2.5f, 10f));

        //powerSources
        powerSources = new List<PowerEquipment>();

        powerSources.Add(new PowerEquipment("PowerLit", 100, powerSources.Count, icon, 10, 0.5f, 50));

        //miners
        miners = new List<MinerEquipment>();

        miners.Add(new MinerEquipment("GX 108", 20, miners.Count, icon, 0.00001f, 1f, 2));
        miners.Add(new MinerEquipment("GX 112", 100, miners.Count, icon, 0.00008f, 3f, 4));
        miners.Add(new MinerEquipment("GX 200", 250, miners.Count, icon, 0.00012f, 5f, 8));

        //serverRacks
        serverRacks = new List<ServerRack>();

        serverRacks.Add(new ServerRack("LT1", 15, serverRacks.Count, icon, 1, rackPrefab));
        serverRacks.Add(new ServerRack("RT2", 100, serverRacks.Count, icon, 2, rackPrefab));
        serverRacks.Add(new ServerRack("LT1", 15, serverRacks.Count, icon, 1, rackPrefab));
        serverRacks.Add(new ServerRack("RT2", 100, serverRacks.Count, icon, 2, rackPrefab));

    }


}
