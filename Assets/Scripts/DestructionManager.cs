using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionManager : MonoBehaviour
{
    Health health;
    Rigidbody2D rb;
    Transform transform;

    [SerializeField] float resistance; // between 0 and 1
    [SerializeField] float[] velocityForDamage;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
        rb = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 curPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        if (collision.gameObject.tag == "Player")
        {
            //float velosity = rb.GetPointVelocity(transform.TransformPoint(curPos));
            Debug.Log(rb.velocity.magnitude);

            if (rb.velocity.magnitude > velocityForDamage[2])
            {
                health.ChangeHealth(-health.GetHealth());
            }
            else if (rb.velocity.magnitude > velocityForDamage[1])
            {
                health.ChangeHealth(-(health.GetHealth() * resistance / 2));
            }
            else if (rb.velocity.magnitude > velocityForDamage[0])
            {
                health.ChangeHealth(-(health.GetHealth() * resistance));
            }
        }
    }
}
