using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    [SerializeField] public float damage;

    //Collider2D colider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.transform.GetComponent<Player>())
        //{
        //    collision.GetComponent<Health>().ChangeHealth(-damage);
        //    Destroy(this.gameObject);
        //}
    }
}
