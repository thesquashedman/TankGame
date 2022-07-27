using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCloseAttack : MonoBehaviour
{

    [SerializeField] float damage;

    [SerializeField] float attckFrequency;

    Collider2D collider;

    GameObject player;

    [SerializeField] float AttackTimer;
    

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        AttackTimer = 0;
        player = GameObject.Find("PlayerTank");
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.transform.GetComponent<Player>())
    //    {
    //        Attack();
    //    }
    //}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.GetComponent<Player>())
        {
            Attack();
        }
    }

    IEnumerable Attack2()
    {
        if (AttackTimer == 0)
        {
            yield return new WaitForSeconds(attckFrequency);
            player.GetComponent<Health>().ChangeHealth(-damage);
        }
        //yield return new WaitForSeconds(attckFrequency);

    }

    void Attack()
    {
        if (AttackTimer <= 0)
        {
            AttackTimer = attckFrequency;
            player.GetComponent<Health>().ChangeHealth(-damage);
        }
    }

    void Timer()
    {
        if (AttackTimer > 0)
        {
            AttackTimer -= Time.deltaTime;
        }
    }
}
