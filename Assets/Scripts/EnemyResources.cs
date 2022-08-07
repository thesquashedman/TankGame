using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyResources : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float cartridges;
    [SerializeField] float fuel;

    [SerializeField] float health;

    Health enemyHealth;
 
    
    
    private void OnEnable() {
        enemyHealth = this.transform.GetComponent<Health>();
        enemyHealth.OnDeath += DropResources;
    }
    private void OnDisable() {
        enemyHealth.OnDeath -= DropResources;
    }
    void DropResources()
    {
        GameObject resource = Instantiate(Resources.Load("Prefabs/Resource"), this.transform.position, Quaternion.identity) as GameObject;
        
        resource.GetComponent<Resource>().SetResources(cartridges, fuel, health);
    }
}
