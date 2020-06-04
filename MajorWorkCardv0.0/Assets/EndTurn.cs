using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    GameObject pEnergy, eEnergy, pDeck, eDeck;
    Energy pEnergyS, eEnergyS;
    Draw pDeckS, eDeckS;
    public GameData gameData;
    void Start()
    {
        pEnergy = GameObject.Find("PlayerEnergy");
        eEnergy = GameObject.Find("EnemyEnergy");
        pDeck = GameObject.Find("PlayerDeck");
        eDeck = GameObject.Find("EnemyDeck");
        pEnergyS = pEnergy.GetComponent<Energy>();
        eEnergyS = eEnergy.GetComponent<Energy>();
        pDeckS = pDeck.GetComponent<Draw>();
    }
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        pEnergyS.reset();
        eEnergyS.reset();
        gameData.roundNum++;
        pDeckS.draw();
        gameData.playerTurn = !gameData.playerTurn;
    }
}
