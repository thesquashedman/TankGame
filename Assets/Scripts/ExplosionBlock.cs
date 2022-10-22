using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBlock : Explosive
{
    // Start is called before the first frame update

    [SerializeField] float activationsForce;
    Health health;
    Rigidbody2D rigidbody;


    void Start()
    {
        GetComponent<Health>().OnDeath += Explode;
        health = GetComponent<Health>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Colision");
        if (rigidbody.velocity.magnitude > activationsForce)
        {
            this.Explode();
            Destroy(this.gameObject);
        }
    }
}
