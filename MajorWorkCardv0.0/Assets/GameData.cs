using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game Data", menuName = "Scriptable Objects/Game Data")]
public class GameData : ScriptableObject
{
    public int roundNum = 1;
    public bool playerTurn = false;
    [SerializeField]
    private List<int> playerDeck = new List<int>();
    [SerializeField]
    private List<int> enemyDeck = new List<int>();
    GameObject pEnergy;
    Energy pEnergyS;
    private void OnEnable()
    {
        if (Random.Range(0, 1) == 1)
        {
            playerTurn = true;
        }
        pEnergy = GameObject.Find("PlayerEnergy");
        pEnergyS = pEnergy.GetComponent<Energy>();
        for (int i = 0; i < 11; i++)
        {
            playerDeck.Add(i);
            enemyDeck.Add(i);
        }
        roundNum = 1;
        shuffle(playerDeck);
        shuffle(enemyDeck);
    }
    private void OnDisable()
    {
        playerDeck.Clear();
        enemyDeck.Clear();
    }
    void shuffle(List<int> list) //Fisher-Yates shuffle
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
    public int getID(bool player)
    {
        List<int> currentDeck;
        if (player)
        {
            currentDeck = playerDeck;
        }
        else
        {
            currentDeck = enemyDeck;
        }
        int temp = currentDeck[0];
        currentDeck.Remove(0);
        return temp;
    }
    public void cardEffect(int id)
    {
        switch(id)
        {
            case 0:
                //do
                pEnergyS.spend(0);
                break;
            case 1:
                //do
                pEnergyS.spend(1);
                break;
            case 2:
                //do
                pEnergyS.spend(2);
                break;
            case 3:
                //do
                pEnergyS.spend(3);
                break;
            case 4:
                //do
                pEnergyS.spend(4);
                break;
            case 5:
                //do
                pEnergyS.spend(5);
                break;
            case 6:
                //do
                pEnergyS.spend(6);
                break;
            case 7:
                //do
                pEnergyS.spend(7);
                break;
            case 8:
                //do
                pEnergyS.spend(9);
                break;
            case 9:
                //do
                pEnergyS.spend(9);
                break;
            case 10:
                //do
                pEnergyS.spend(10);
                break;
        }
    }
}
