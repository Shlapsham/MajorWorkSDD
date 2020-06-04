using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Draw : MonoBehaviour
{
    public GameObject cardPrefab;
    public GameObject handObject;
    public List<GameObject> newCardAdd;
    public GameObject newCard;
    Card cardS;
    public bool drawn = false;
    bool who = false;
    void Start()
    {
        transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
        if (gameObject.name == "PlayerDeck")
        {
            who = true;
        }
    }
    void Update()
    {
        
    }
    private void OnMouseDown()
    {

    }
    public void draw()
    {
        newCardAdd.Remove(newCard);
        newCard = Instantiate(cardPrefab, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity) as GameObject;
        cardS = newCard.GetComponent<Card>();
        cardS.whereFrom(who);
        newCard.transform.parent = handObject.transform;
        newCardAdd.Add(newCard);
        drawn = true;
    }
}
