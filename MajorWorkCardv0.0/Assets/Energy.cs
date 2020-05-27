using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Energy : MonoBehaviour
{
    [SerializeField]
    public GameObject[] energy;
    public int available;
    public Sprite yes, no, locked;
    public GameData gameData;
    SpriteRenderer[] spriteR;
    [SerializeField]
    bool flag = false;
    void Start()
    {
        energy = new GameObject[transform.childCount];
        spriteR = new SpriteRenderer[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            energy[i] = transform.GetChild(i).gameObject;
            spriteR[i] = energy[i].GetComponent<SpriteRenderer>();
            spriteR[i].sprite = locked;
        }
    }
    void Update()
    {
        
    }
    public void reset()
    {
        if (gameData.roundNum <= 10)
        {
            available = gameData.roundNum;
        }
        else
        {
            available = 10;
        }
        for (int i = 0; i <= available - 1; i++)
        {
            flag = true;
            spriteR[i].sprite = yes;
        }
    }
    public bool spend(int amount)
    {
        bool possible = false;
        if (amount <= available)
        {
            possible = true;
            for (int i = available - 1; i >= available - amount - 1; i--)
            {
                spriteR[i].sprite = no;
            }
        }
        return possible;
    }
    public void roundNumInc()
    {

    }
}
