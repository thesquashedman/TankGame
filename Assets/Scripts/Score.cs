using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    private void OnEnable() {
        
        DestructionManager.EnemyDied += UpdateScore;
    }
    private void OnDisable() 
    {
        DestructionManager.EnemyDied -= UpdateScore;
    }
    void UpdateScore()
    {
        score++;
        
        GetComponent<Text>().text = "" + score;
    }
}
