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

    [SerializeField] float rotateSpeed;
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
    void RotateGun()
    {
        
        if(Input.GetKey(KeyCode.UpArrow))
        {

            this.transform.Rotate(-rotateSpeed * Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Resource.OnPickup += pickupCartridges;
    }

    // Update is called once per frame
    void Update()
    {
        RotateGun();
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
    void pickupCartridges(float cartridges, float fuel, float health)
    {
        this.cartridges += (int)cartridges;
    }
    
}
