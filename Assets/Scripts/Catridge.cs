using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catridge : MonoBehaviour
{

    DamageManager damageManager;

    // Start is called before the first frame update
    void Start()
    {
        damageManager = GetComponent<DamageManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Block")
        {
            collision.gameObject.GetComponent<Health>().ChangeHealth(-damageManager.damage);
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

}
