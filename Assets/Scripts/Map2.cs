using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map2 : MonoBehaviour
{
    [SerializeField] Player player;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        //if (GameObject.Find("Map").GetComponent<Map>() != null)
        //{
        //    map = GameObject.Find("Map").GetComponent<Map>();
        //}
        //map = GameObject.Find("Map").GetComponent<Map>();
        if (SceneManager.GetActiveScene().name != "1") //&& inMap != false
        {
            player.LoadPlayer();
        }
        //player.LoadPlayer();  //!!!!!!!!!!!!!!!!!
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.GetComponent<Player>())
        {
            player.SavePlayer();
            //SceneManager.LoadScene("" + (player.curentLocationIndex));
            player.curentLocationIndex++;
            player.SavePlayer();
            OpenShop();
        }
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    Debug.Log("TirgerWasActivated");
    //    if (other.transform.GetComponent<Player>())
    //    {
    //        player.SavePlayer();
    //        LoadMapScene();
    //    }
    //}

    public void OpenShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void OpenNextLocation()
    {
        SceneManager.LoadScene("" + (player.curentLocationIndex));
    }
}
