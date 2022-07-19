using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 0;
    public event Action OnDeath;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckHealth();
    }

    public float GetHealth()
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
            if(OnDeath != null)
            {
                OnDeath.Invoke();
            }
            
            Destroy(this.gameObject);
        }
    }

    public void SetHealth(float health)
    {
        this.health = health;
    }
}
