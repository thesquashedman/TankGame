using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    // Start is called before the first frame update
    protected Collider2D[] inRadius;
    [SerializeField] protected float ExplosionForceMulti = 5;
    [SerializeField] protected float ExplosionRadius = 5;

    void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Explode()
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
