using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card: MonoBehaviour
{
    public GameData gameData;
    public int id;
    bool fromPlayer;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (gameObject.transform.position.y >= -50)
        {
            gameData.cardEffect(id);
            Destroy(gameObject);
        }
    }
    public void whereFrom(bool player)
    {
        fromPlayer = player;
        id = gameData.getID(fromPlayer);
    }
}
