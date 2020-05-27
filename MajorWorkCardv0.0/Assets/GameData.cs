using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game Data", menuName = "Scriptable Objects/Game Data")]
public class GameData : ScriptableObject
{
    public int roundNum = 1;
    void OnEnable()
    {
        roundNum = 1;
    }
}
