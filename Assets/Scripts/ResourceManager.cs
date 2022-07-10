using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text woodT;
    public Text fuelT;
    public Text metalT;

    public int wood = 0;
    public int fuel = 0;
    public int metal = 0;
    private void OnEnable() {
        Resource.OnPickup += UpdateResources;
    }
    private void OnDisable() {
        Resource.OnPickup -= UpdateResources;
    }
    void UpdateResources(float wood, float fuel, float metal)
    {
        this.wood += (int)wood;
        this.fuel += (int)fuel;
        this.metal += (int)metal;
        
        woodT.text = "" + this.wood;
        fuelT.text = "" + this.fuel;
        metalT.text = "" + this.metal;
    }
}
