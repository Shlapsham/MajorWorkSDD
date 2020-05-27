using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField]
    bool holding = false;
    float spaceBetween = 50; //space inbetweeen cards
    float positionOf1in10; //x pos of the first card in a hand of 10
    [SerializeField]
    public float handPosition;
    [SerializeField]
    public float cardsInHand;
    float handYValue = -220;
    float height;
    Vector2 currentPos;
    Vector2 basePos;
    Vector2 baseToCurrent;
    void Start()
    {
        positionOf1in10 = -5 * spaceBetween;
    }
    void Update()
    {
        currentPos = transform.position;
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
        basePos = new Vector2(spaceBetween * (((10f - cardsInHand) - 1f )/ 2 + handPosition) + positionOf1in10, handYValue);
        if (!holding && currentPos != basePos)
        {
            transform.position = Vector2.MoveTowards(transform.position, basePos, 16);
        }
        baseToCurrent = basePos - currentPos;
        transform.localScale = Vector3.Lerp(new Vector3(0.25f, 0.25f, 0.25f), new Vector3(0.75f, 0.75f, 0.75f), (Vector2.SqrMagnitude(baseToCurrent)/ 16384) - 0.2f);
    }
}
