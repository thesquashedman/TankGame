using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Road", menuName = "Road")]
[System.Serializable]
public class Road : ScriptableObject
{
    [SerializeField] public string roadName;
}

