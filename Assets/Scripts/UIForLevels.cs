using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIForLevels : MonoBehaviour
{

    [SerializeField] GameObject fuel;
    [SerializeField] GameObject catridges;

    Player player;


    void Start()
    {
        player = GameObject.Find("PlayerTank").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        fuel.GetComponent<Text>().text = "" + (int)player.fuel;

        catridges.GetComponent<Text>().text = "" + player.cartridges            ;

    }
}
