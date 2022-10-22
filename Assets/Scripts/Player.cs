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
    public string curentLocationName = "Location#1"; //!!!!

    Engine engine;
    TankGun tg;
    Health plyHealth;

    public bool playerInWater = false;

    public int gunUpgradeLevel;



    public Player(Player player)
    {
        fuel = player.fuel;
        cartridges = player.cartridges;
        helth = player.helth;
        curentLocationName = player.curentLocationName;
        //player.SavePlayer();
    }

    // Start is called before the first frame update
    void Start()
    {
        //this.SavePlayer();
        rb = GetComponent<Rigidbody2D>();
        engine = GetComponent<Engine>();
        tg = GetComponentInChildren<TankGun>();
        plyHealth = GetComponent<Health>();

        Resource.OnPickup += pickupHealth;
        if (curentLocationName != "Location#1")
        {
            this.LoadPlayer();
        }
        gunUpgradeLevel = 0;
        //else
        //{
        //    this.SavePlayer();
        //}
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
        Debug.Log("loading player");
        PlayerData data = SaveSystem.LoadPlayer();

        Debug.Log(data.fuel);
        if(engine == null)
        {
            Debug.Log("No engine");
        }
        engine.fuel = data.fuel;
        tg.cartridges = data.cartridges;
        plyHealth.SetHealth(data.health);
        curentLocationName = data.curentLocationName;
        SetGunDamage(25);
        //this.curentLocation = data.curentLocation;

        //fuel = data.fuel;
        //cartridges = data.cartridges;
    }
    void pickupHealth(float cartridges, float fuel, float health)
    {
        plyHealth.ChangeHealth(health);
    }
    public void SetGunDamage(float damage)
    {
        tg.damage = damage;
    }
    public void SetEngineSpeeds(int[] speed)
    {
        engine.SetAllSpeeds(speed);
    }
    public void GainHealth(float health)
    {
        plyHealth.ChangeHealth(health);
    }
    public void upgradeGun()
    {
        SetGunDamage(tg.damage + 25);
        gunUpgradeLevel++;
    }

    //public void changeLocation(Location newLocation)
    //{
    //    curentLocation = newLocation;
    //}
}
