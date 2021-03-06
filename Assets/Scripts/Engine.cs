using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    [SerializeField] int[] speed;
    [SerializeField] float[] fuelUsagePerSec;
    [SerializeField] public float fuel;
    [SerializeField] public int powerLevel = 0;
    [SerializeField] int engineTemperature;
    [SerializeField] float coolingIndex;
    Rigidbody2D tankRB;

    // Start is called before the first frame update
    void Start()
    {
        tankRB = GetComponent<Rigidbody2D>();
        Resource.OnPickup += pickupFuel;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Gas();
        //GasVelocity();
        ChangeEnginePower();
        
    }

    void Gas()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            if (fuel > 0)
            { 
                tankRB.AddForce(new Vector2(speed[powerLevel], 0));
                fuel -= fuelUsagePerSec[powerLevel] * Time.deltaTime;
            }
        }
    }
    void GasVelocity()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            if (fuel > 0)
            { 
               
                tankRB.velocity = Vector2.right * speed[powerLevel] * Time.deltaTime; ///Time.FixedDeltaTime
                fuel -= fuelUsagePerSec[powerLevel] * Time.deltaTime;
            }
        }
    }
    void ChangeEnginePower()
    {
        if (Input.GetKey("1"))
        {
            powerLevel = 0;
        }
        else if (Input.GetKey("2"))
        {
            powerLevel = 1;
        }
        else if (Input.GetKey("3"))
        {
            powerLevel = 2;
        }
    }
    void pickupFuel(float wood, float fuel, float metal)
    {
        this.fuel += fuel;
    }
}
