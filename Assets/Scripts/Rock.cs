using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 target;
    bool hasTarget;

    Vector2 startPosition;

    [SerializeField] float speed;
    [SerializeField] float arcHeight;

    [SerializeField] float damage;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasTarget)
        {
            float x0 = startPosition.x;
            float x1 = target.x;
            float dist = x1 - x0;
            float nextX = Mathf.MoveTowards(transform.position.x, x1, speed * Time.deltaTime);
            float baseY = Mathf.Lerp(startPosition.y, target.y, (nextX - x0)/dist);
            float arc = arcHeight * (nextX - x0) *(nextX - x1) /(-0.25f * dist *dist);
            Vector3 nextPos = new Vector3(nextX, baseY + arc, transform.position.z);

            transform.rotation = LookAt2D(nextPos - transform.position);
            transform.position = nextPos;
        }   
    }
    
    public void SetTarget(Vector3 target)
    {
        this.target = target;
        hasTarget = true;
    }

    Quaternion LookAt2D(Vector2 forward)
    {
        return Quaternion.Euler(0,0,Mathf.Atan2(forward.y, forward.x) *Mathf.Rad2Deg);
    }   
    private void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("collide");
        if(other.transform.GetComponent<Player>())
        {
            other.GetComponent<Health>().ChangeHealth(-damage);
            Destroy(this.gameObject);
        }
        else //if(other.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
