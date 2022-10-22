using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    Player player;
    Map map;
    //static bool inMap = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        //if (GameObject.Find("Map").GetComponent<Map>() != null)
        //{
        //    map = GameObject.Find("Map").GetComponent<Map>();
        //}
        //map = GameObject.Find("Map").GetComponent<Map>();
        if (player.curentLocationName != "1") //&& inMap != false
        {
            player.LoadPlayer();
        }
        //player.LoadPlayer();  //!!!!!!!!!!!!!!!!!
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToTheLocation(Location newLocaiton)
    {
        map = GameObject.Find("Map").GetComponent<Map>();
        if (map.ConectedWithLocation(newLocaiton) != null)
        {
            Road roadToMove = map.ConectedWithLocation(newLocaiton);

            //player.LoadPlayer(); //??
            Location curentLoc;

            player.curentLocationName = newLocaiton.locationName;
            player.SavePlayer();//??
            //inMap = false;



            //SceneManager.LoadScene(newLocaiton.locationName);
            SceneManager.LoadScene(roadToMove.roadName);
        }
    }

    public void LoadMapScene()
    {
        //inMap = true;
        player.SavePlayer();
        SceneManager.LoadScene("Map");
        //player.LoadPlayer();
    }

}
