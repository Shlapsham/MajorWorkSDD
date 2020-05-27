using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Hand : MonoBehaviour
{
    public GameObject CardPrefab;
    public GameObject Deck;
    public List<GameObject> Cards;
    [SerializeField]
    GameObject newCard;
    Draw draw;
    void Start()
    {
        draw = Deck.GetComponent<Draw>();
    }
    void Update()
    {
        drawCard();
        updateCards();
    }
    void drawCard()
    {
        if (draw.newCardAdd.Count() != 0)
        {
            newCard = draw.newCardAdd[draw.newCardAdd.Count() - 1];
        }
        if (draw.drawn)
        {
            Cards.Add(newCard);
            draw.drawn = false;
        }
    }
    void updateCards()
    {
        foreach(GameObject card in Cards)
        {
            if (card == null)
            {
                Cards.Remove(card);
            }
            else
            {
                Drag drag = card.GetComponent<Drag>();
                drag.cardsInHand = Cards.Count();
                drag.handPosition = Cards.IndexOf(card) + 1;
            }
        }
    }
}
