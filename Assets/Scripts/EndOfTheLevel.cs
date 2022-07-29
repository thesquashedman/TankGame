using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfTheLevel : MonoBehaviour
{

    Player player;
    GameSceneManager sm;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        sm = GameObject.Find("GameSceneManager").GetComponent<GameSceneManager>();
    }

    //private void OnTriggerEnter2D(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        LoadMapScene();
    //    }
    //    Debug.Log("TirgerWasActivated");
    //}

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("TirgerWasActivated");
        if (other.transform.GetComponent<Player>())
        {
            player.SavePlayer();
            LoadMapScene();
        }
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        player.SavePlayer();
    //        LoadMapScene();
    //    }
    //    Debug.Log("TirgerWasActivated");
    //}



    void LoadMapScene()
    {
        sm.LoadMapScene();
    }
}
