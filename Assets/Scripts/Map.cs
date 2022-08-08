using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    Player player;

    [SerializeField] public Location[] locations;

    Location playerCurentLocation;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Road ConectedWithLocation(Location other)
    {
        //Debug.Log("#1");
        for (int i = 0; i < locations.Length; i++)
        {
            if (player.curentLocationName == locations[i].locationName)
            {
                playerCurentLocation = locations[i];
                break;
            }
        }

        for (int i = 0; i < playerCurentLocation.conectionsWithOtheLocations.Count; i++)
        {
            //Debug.Log("#2");
            if (playerCurentLocation.conectionsWithOtheLocations[i].locationName == other.locationName)
            {
                //return playerCurentLocation.roadsConectionsWithOtheLocations[i];
            }
        }
        return null;
    }
}
