using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBlock : Explosive
{
    // Start is called before the first frame update
    

    void Start()
    {
        GetComponent<Health>().OnDeath += Explode;
    }

    // Update is called once per frame
    
}
