using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject MainCanvas;

    public Button shopButton, researchButton, statButton, converterButton;

    public Button rackButton, powerButton, coolersButton, minerButton;

    public GameObject rackMenu, powerMenu, coolersMenu, minerMenu;

    public void closeShopMenu()
    {
        MainCanvas.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        shopButton.interactable = true;
    }


    //TODO optimisere
    public void openMinerMenu()
    {
        rackButton.interactable = true;
        powerButton.interactable = true;
        coolersButton.interactable = true;
        minerButton.interactable = false;

        rackMenu.SetActive(false);  
        powerMenu.SetActive(false);
        coolersMenu.SetActive(false);
        minerMenu.SetActive(true);
    }
    public void openCoolerMenu()
    {
        rackButton.interactable = true;
        powerButton.interactable = true;
        coolersButton.interactable = false;
        minerButton.interactable = true;

        rackMenu.SetActive(false);
        powerMenu.SetActive(false);
        coolersMenu.SetActive(true);
        minerMenu.SetActive(false);
    }
    public void openRackMenu()
    {
        rackButton.interactable = false;
        powerButton.interactable = true;
        coolersButton.interactable = true;
        minerButton.interactable = true;

        rackMenu.SetActive(true);
        powerMenu.SetActive(false);
        coolersMenu.SetActive(false);
        minerMenu.SetActive(false);
    }
    public void openPowerMenu()
    {
        rackButton.interactable = true;
        powerButton.interactable = false;
        coolersButton.interactable = true;
        minerButton.interactable = true;

        rackMenu.SetActive(false);
        powerMenu.SetActive(true);
        coolersMenu.SetActive(false);
        minerMenu.SetActive(false);
    }
}
