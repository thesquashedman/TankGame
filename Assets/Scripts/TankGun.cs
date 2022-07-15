using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankGun : MonoBehaviour
{

    [SerializeField] public int cartridges;
    [SerializeField] Transform placeToSpawnCatridge;
    [SerializeField] float catridgeSpeed;
    [SerializeField] float reloadTime;

    [SerializeField] GameObject gunCartridgePref;
    GameObject curCatridge;

    float timePassed;
    //DamageManager damMang;

    void Shoot()
    {
        if (Input.GetKeyDown("w"))
        {
            
            if (cartridges > 0 && timePassed > reloadTime)
            {
                curCatridge = Instantiate(gunCartridgePref, new Vector3(placeToSpawnCatridge.position.x, placeToSpawnCatridge.position.y, placeToSpawnCatridge.position.z), Quaternion.identity);
                curCatridge.GetComponent<Rigidbody2D>().AddForce(this.transform.forward * catridgeSpeed);
                cartridges--;
                timePassed = 0;
            }
            
        }
        timePassed += Time.deltaTime;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void FixedUpdate()
    {
        
    }


//Don't need this, unless you want to destroy the gun itself?
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(this.gameObject);
    }
}
