using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] float fuel;
    [SerializeField] float fuelUsagePerSec;
    [SerializeField] int engineTemperature;
    [SerializeField] float coolingIndex;
    Rigidbody2D tankRB;

    // Start is called before the first frame update
    void Start()
    {
        tankRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Gass();
    }

    void Gass()
    {
        if (Input.GetKey(KeyCode.Space)) //Input.GetKeyDown("space")
        {
            if (fuel > 0)
            { 
                tankRB.AddForce(new Vector2(speed, 0));
                fuel -= fuelUsagePerSec;
            }
        }
    }
    void ChangeEnginPower(int change)
    { 
    
    }

}
