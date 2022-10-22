using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData 
{
    public float fuel;
    public int cartridges;
    public float health;
    public string curentLocationName;
    public int curentLocationIndex;

    public PlayerData(Player player)
    {
        fuel = player.fuel;
        cartridges = player.cartridges;
        health = player.helth;
        curentLocationName = player.curentLocationName;
        curentLocationIndex = player.curentLocationIndex;
        //curentLocation = player.curentLocation;
    }
}
