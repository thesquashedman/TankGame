using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyResources : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float wood;
    [SerializeField] float fuel;

    [SerializeField] float metal;

    Health health;
 
    
    
    private void OnEnable() {
        health = this.transform.GetComponent<Health>();
        health.OnDeath += DropResources;
    }
    private void OnDisable() {
        health.OnDeath -= DropResources;
    }
    void DropResources()
    {
        GameObject resource = Instantiate(Resources.Load("Prefabs/Resource"), this.transform.position, Quaternion.identity) as GameObject;
        
        resource.GetComponent<Resource>().SetResources(wood, fuel, metal);
    }
}
