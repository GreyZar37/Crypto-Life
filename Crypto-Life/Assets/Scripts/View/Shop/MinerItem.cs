using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MinerItem : MonoBehaviour
{

    public TextMeshProUGUI priceText, minerNameText, incomeText, heatOutput, powerConsumption, amount;
    public Image minerImage;
    public Button button;

    [SerializeField]
    public MinerEquipment minerEquipment;

    private void Start()
    {

    }

    public void initialize(MinerEquipment data)
    {
        minerEquipment = data;
        priceText.text = string.Format("Buy(${0})", minerEquipment.price);
        minerNameText.text = string.Format("Miner: {0}", minerEquipment.name);
        incomeText.text = string.Format("Income: {0} DEV/s", minerEquipment.income);
        heatOutput.text = string.Format("Heat output: {0} C°", minerEquipment.heatProduction);
        powerConsumption.text = string.Format("Power usage: {0} W", minerEquipment.powerUsage);
        amount.text = string.Format("Owned: {0}", minerEquipment.amount);

        minerImage.sprite = minerEquipment.icon;
        button.onClick.AddListener(onClick);

    }

    void onClick()
    {
        minerEquipment.amount++;
        amount.text = string.Format("Owned: {0}", minerEquipment.amount);
    }
}
