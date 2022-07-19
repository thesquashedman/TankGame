using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIForLevels : MonoBehaviour
{

    [SerializeField] GameObject fuel;
    [SerializeField] GameObject catridges;
    [SerializeField] GameObject health;
    [SerializeField] GameObject powerLevel;

    //Player player;

    GameObject player;


    void Start()
    {
        player = GameObject.Find("PlayerTank");
    }

    // Update is called once per frame
    void Update()
    {
        fuel.GetComponent<Text>().text = "" + (int)player.GetComponent<Player>().fuel;

        catridges.GetComponent<Text>().text = "" + player.GetComponent<Player>().cartridges;

        health.GetComponent<Text>().text = "" + player.GetComponent<Player>().helth;

        powerLevel.GetComponent<Text>().text = "" + (player.GetComponent<Engine>().powerLevel + 1);
    }
}
