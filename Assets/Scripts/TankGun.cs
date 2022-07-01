using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankGun : MonoBehaviour
{

    [SerializeField] int cartridges;
    [SerializeField] Transform placeToSpawnCatridge;
    [SerializeField] float catridgeSpeed;
    [SerializeField] float reloadTime;

    [SerializeField] GameObject gunCartridgePref;
    GameObject curCatridge;
    //DamageManager damMang;

    void Shout()
    {
        if (Input.GetKeyDown("w"))
        {
            if (cartridges > 0)
            {
                curCatridge = Instantiate(gunCartridgePref, new Vector3(placeToSpawnCatridge.position.x, placeToSpawnCatridge.position.y, placeToSpawnCatridge.position.z), Quaternion.identity);
                curCatridge.GetComponent<Rigidbody2D>().AddForce(new Vector2(catridgeSpeed, 0));
                cartridges--;
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Shout();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
