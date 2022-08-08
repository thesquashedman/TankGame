using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    GameObject player;
    Engine engine;
    Player playerComp;
    [SerializeField] int waterResistanse;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        engine = player.GetComponent<Engine>();

        playerComp = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Water");

        if ((collision.gameObject.tag == "Player") && !(playerComp.playerInWater))
        {
            engine.ChangeAllSpeeds(-waterResistanse);
            playerComp.playerInWater = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            engine.ChangeAllSpeeds(waterResistanse);
            playerComp.playerInWater = false;
        }
    }
}
