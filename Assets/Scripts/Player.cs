using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class Player : MonoBehaviour
{

    public float speed;
    Rigidbody2D rb;

    public float fuel;
    public int cartridges;

    Engine engine;
    TankGun tg;

    public Player(Player player)
    {
        fuel = player.fuel;
        cartridges = player.cartridges;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        engine = GetComponent<Engine>();
        tg = GetComponentInChildren<TankGun>();
    }


    private void Update()
    {
        fuel = engine.fuel;
        cartridges = tg.cartridges;
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

        //fuel = data.fuel;
        //cartridges = data.cartridges;
    }
}
