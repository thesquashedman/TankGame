using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class Player : MonoBehaviour
{

    //[SerializeField] public Location curentLocation;

    

    public float speed;
    Rigidbody2D rb;

    public float fuel;
    public int cartridges;
    public float helth;
    public string curentLocationName;

    Engine engine;
    TankGun tg;
    Health plyHealth;

    

    public Player(Player player)
    {
        fuel = player.fuel;
        cartridges = player.cartridges;
        helth = player.helth;
        curentLocationName = player.curentLocationName;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        engine = GetComponent<Engine>();
        tg = GetComponentInChildren<TankGun>();
        plyHealth = GetComponent<Health>();
        if (curentLocationName != "Location#1")
        {
            this.LoadPlayer();
        }
    }


    private void Update()
    {
        fuel = engine.fuel;
        cartridges = tg.cartridges;
        helth = plyHealth.GetHealth();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = rb.velocity.magnitude; //??
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        engine.fuel = data.fuel;
        tg.cartridges = data.cartridges;
        plyHealth.SetHealth(data.health);
        curentLocationName = data.curentLocationName;
        //this.curentLocation = data.curentLocation;

        //fuel = data.fuel;
        //cartridges = data.cartridges;
    }

    //public void changeLocation(Location newLocation)
    //{
    //    curentLocation = newLocation;
    //}
}
