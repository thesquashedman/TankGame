using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData 
{
    public float fuel;
    public int cartridges;

    public PlayerData(Player player)
    {
        fuel = player.fuel;
        cartridges = player.cartridges;
    }
}
