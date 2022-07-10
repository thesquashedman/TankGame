using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockThrower : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    float timePassed;
    [SerializeField] float reloadRate;
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if(timePassed > reloadRate)
        {
            ThrowRockAtPlayer();
            timePassed = 0;
        }
    }

    void ThrowRockAtPlayer()
    {
        GameObject rock = Instantiate(Resources.Load("Prefabs/Rock"), this.transform.position, Quaternion.identity) as GameObject;
        rock.GetComponent<Rock>().SetTarget(player.transform.position);
    }
}
