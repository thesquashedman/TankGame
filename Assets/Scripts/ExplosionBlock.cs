using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBlock : MonoBehaviour
{
    // Start is called before the first frame update
    Collider2D[] inRadius;
    [SerializeField] float ExplosionForceMulti = 5;
    [SerializeField] float ExplosionRadius = 5;

    void Start()
    {
        GetComponent<Health>().OnDeath += Explode;
    }

    // Update is called once per frame
    void Explode()
    {
        inRadius = Physics2D.OverlapCircleAll(transform.position, ExplosionRadius);

        foreach (Collider2D o in inRadius)
        {
            Debug.Log("moo");
            Rigidbody2D mRigid = o.GetComponent<Rigidbody2D>();
            if(mRigid != null)
            {
                Vector2 distanceVector = o.transform.position - this.transform.position;
                if(distanceVector.magnitude > 0)
                {
                    float explosionForce = ExplosionForceMulti / distanceVector.magnitude;
                    mRigid.AddForce(distanceVector.normalized * explosionForce);
                }
            }
        }
    }
}
