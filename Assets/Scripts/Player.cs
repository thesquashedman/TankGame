using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//[System.Serializable]
public class Player : MonoBehaviour
{

    //[SerializeField] public Location curentLocation;

    

    public float speed;
    Rigidbody2D rb;

    public float fuel;
    public int cartridges;
    public float helth;
    public string curentLocationName = "1"; //!!!!
    public int curentLocationIndex = 1;

    public Engine engine;
    TankGun tg;
    Health plyHealth;

    public bool playerInWater = false;



    public Player(Player player)
    {
        fuel = player.fuel;
        cartridges = player.cartridges;
        helth = player.helth;
        //curentLocationName = player.curentLocationName;

        curentLocationName = player.curentLocationName;//SceneManager.GetActiveScene().name;

        curentLocationIndex = player.curentLocationIndex;
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



        if (SceneManager.GetActiveScene().name != "1")
        {
            this.LoadPlayer();
        }
        else 
        {
            Debug.Log(SceneManager.GetActiveScene().name);
            curentLocationName = SceneManager.GetActiveScene().name;

            curentLocationIndex = 1; //int.Parse(SceneManager.GetActiveScene().name);
            Debug.Log("ABCABCABC");
        }
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
        curentLocationIndex = data.curentLocationIndex;
        //this.curentLocation = data.curentLocation;

        //fuel = data.fuel;
        //cartridges = data.cartridges;
    }
    void pickupHealth(float cartridges, float fuel, float health)
    {
        plyHealth.ChangeHealth(health);
    }

    //public void changeLocation(Location newLocation)
    //{
    //    curentLocation = newLocation;
    //}
}
