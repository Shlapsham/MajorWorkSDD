using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField]
    bool holding = false;
    float positionOf1in10 = -250; //x pos of the first card in a hand of 10
    float spaceBetween = 50; //space inbetweeen cards
    [SerializeField]
    float rowPosition;
    [SerializeField]
    float cardsInHand;
    Vector2 currentPos;
    Vector2 basePos;
    void Start()
    {
        
    }
    void Update()
    {
        currentPos = (Vector2)transform.position;
        mouseDrag();
        returnToBase();
    }
    private void OnMouseDown()
    {
        holding = !holding;
    }
    void mouseDrag()
    {
        if (holding)
        {
            transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 0.8f);
        }
    }
    void returnToBase()
    {
        basePos = new Vector2((spaceBetween * (10f - cardsInHand) * rowPosition) / 2 + positionOf1in10, -100);
        if (!holding && currentPos != basePos)
        {
            transform.position = Vector2.MoveTowards(transform.position, basePos, 25);
        }
    }
}
