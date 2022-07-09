using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionsWithTankManager : MonoBehaviour
{

    [SerializeField] float bouncingFromTank = 0;

    GameObject player;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        player = GameObject.Find("PlayerTank");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector2 newVect = (this.transform.position - player.transform.position).normalized;
            //Debug.Log(rb.velocity.magnitude);
            rb.AddForce(newVect * bouncingFromTank);
            Debug.Log(rb.velocity.magnitude);
        }
    }
}
