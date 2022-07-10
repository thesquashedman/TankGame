using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Resource : MonoBehaviour
{
    public float wood;
    public float fuel;
    public float metal;

    public static event Action<float, float, float> OnPickup;

    public void SetResources(float wood, float fuel, float metal)
    {
        this.wood = wood;
        this.fuel = fuel;
        this.metal = metal;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(OnPickup != null)
            {
                OnPickup.Invoke(wood, fuel, metal);
            }
            
            Destroy(this.gameObject);
        }
    }
}
