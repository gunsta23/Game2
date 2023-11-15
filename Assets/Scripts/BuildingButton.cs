using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingButton : MonoBehaviour
{
    //public BuildingPlacer buildingPlacer;
    public GameObject buildingPrefab;

    public void TryBuy()
    {
        int price = buildingPrefab.GetComponent<Building>().Price;
       // if (FindObjectOfType<Resources>().money >= price)
        {
            //FindObjectOfType<Resources>().money -= price;
        }

    }
}
