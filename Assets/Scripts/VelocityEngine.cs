using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityEngine : Engine
{
    // Start is called before the first frame update
    
    protected override void Gas()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            if (fuel > 0)
            { 
                
                Vector2 grav = tankRB.gravityScale * Vector2.down;
                Vector2 forward = this.transform.right * speed[powerLevel] * Time.deltaTime;
                tankRB.velocity = forward + grav; ///Time.FixedDeltaTime
                fuel -= fuelUsagePerSec[powerLevel] * Time.deltaTime;
            }
        }
    }
}
