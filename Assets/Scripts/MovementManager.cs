using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{

    [SerializeField] float speed = 0;

    Rigidbody2D rb;
    Transform transf;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transf = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(speed, 0));
    }
}
