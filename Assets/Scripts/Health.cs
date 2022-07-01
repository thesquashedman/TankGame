using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckHealth();
    }

    float GetHealth()
    {
        return health;
    }

    public void ChangeHealth(float change)
    {
        this.health += change;

    }

    public void CheckHealth()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
