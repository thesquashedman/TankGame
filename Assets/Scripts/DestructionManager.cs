using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DestructionManager : MonoBehaviour
{
    Health health;
    Rigidbody2D rb;
    Transform transform;
    [SerializeField] float delayForDamage = 0;
    [SerializeField] float minimumDamage = 1;

    Player player;

    public static event Action EnemyDied;

    [SerializeField] float resistance; // between 0 and 1
    [SerializeField] float[] velocityForDamage;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
        rb = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        health.OnDeath += OnDying;
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
            //Debug.Log(rb.velocity.magnitude);

            if (player.GetSpeed() > velocityForDamage[2])
            {
                //health.ChangeHealth(-health.GetHealth());
                StartCoroutine(WaitForDamage(-health.GetHealth()));
            }
            else if (player.GetSpeed() > velocityForDamage[1])
            {
                if (health.GetHealth() * resistance > minimumDamage)
                {
                    StartCoroutine(WaitForDamage(-health.GetHealth() * resistance));
                }
                else 
                {
                    StartCoroutine(WaitForDamage(-minimumDamage * 3));
                }
                //health.ChangeHealth(-(health.GetHealth() * resistance / 2));
            }
            else if (player.GetSpeed() > velocityForDamage[0])
            {
                if (-health.GetHealth() * resistance > minimumDamage)
                {
                    StartCoroutine(WaitForDamage(-health.GetHealth() * (resistance / 2)));
                }
                else
                {
                    StartCoroutine(WaitForDamage(-minimumDamage));
                }
                //StartCoroutine(WaitForDamage(-health.GetHealth() * resistance));
                //health.ChangeHealth(-(health.GetHealth() * resistance));
            }
            
        }
    }
    void OnDying()
    {
        if(EnemyDied != null)
        {
            EnemyDied.Invoke();
        }
        
        
    }

    IEnumerator WaitForDamage(float damage)
    {
        yield return new WaitForSeconds(delayForDamage);
        health.ChangeHealth(damage);
    }

}
