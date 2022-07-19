using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    Player player;
    Map map;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerTank").GetComponent<Player>();
        map = GameObject.Find("Map").GetComponent<Map>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToTheLocation(Location newLocaiton)
    {
        if (map.ConectedWithLocation(newLocaiton))
        {
            player.curentLocationName = newLocaiton.locationName;
            player.SavePlayer();
            SceneManager.LoadScene(newLocaiton.locationName);
            player.LoadPlayer();
        }
    }

    public void LoadMapScene()
    {
        SceneManager.LoadScene("Map");
    }

}
