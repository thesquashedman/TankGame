using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
//using System.Collections.Generic;


[CreateAssetMenu(fileName = "New Location", menuName = "Locaiton")]
public class Location : ScriptableObject
{
    [SerializeField] public string locationName;
    [SerializeField] float amountOfResurses;
    [SerializeField] float levelOfDanger;
    [SerializeField] int typeOfLoacation;

    [SerializeField] public List<Location> conectionsWithOtheLocations;

    //[SerializeField] public List<KeyValuePair<Location, int>> conectionsWithOtheLocations; //should be Location, Road>

    // Start is called before the first frame update
    void Start()
    {
        var conectionsWithOtheLocations = new List<KeyValuePair<Location, int>>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GetLoacationType()
    {
        return typeOfLoacation;
    }

    //bool ConectedWithLocation(Location other)
    //{
    //    for (int i = 0; i < conectionsWithOtheLocations.Count; i++)
    //    {
    //        if (conectionsWithOtheLocations[i].Key.locationName == other.locationName)
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}
}
