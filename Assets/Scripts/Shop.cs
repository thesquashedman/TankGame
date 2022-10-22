using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Button gunUpgrade;
    [SerializeField] Image gunProgress;
    public Player player;

    void Start()
    {
        gunUpgrade.onClick.AddListener(UpgradeGun);
    }
    void UpgradeGun()
    {
        //player.upgradeGun();
        gunProgress.fillAmount += .25f;
    }

    // Update is called once per frame
    
}
