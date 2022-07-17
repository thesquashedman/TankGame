using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    Player player;

    Location[] locations;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerTank").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool ConectedWithLocation(Location other)
    {
        //Debug.Log("#1");
        for (int i = 0; i < player.curentLocation.conectionsWithOtheLocations.Count; i++)
        {
            //Debug.Log("#2");
            if (player.curentLocation.conectionsWithOtheLocations[i].locationName == other.locationName)
            {
                return true;
            }
        }
        return false;
    }
}
