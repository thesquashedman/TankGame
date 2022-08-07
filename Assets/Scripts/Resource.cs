using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Resource : MonoBehaviour
{
    public float cartridges;
    public float fuel;
    public float health;

    public static event Action<float, float, float> OnPickup;

    public void SetResources(float cartridges, float fuel, float health)
    {
        this.cartridges = cartridges;
        this.fuel = fuel;
        this.health = health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(OnPickup != null)
            {
                OnPickup.Invoke(cartridges, fuel, health);
            }
            
            Destroy(this.gameObject);
        }
    }
}
