using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    public GameObject cardPrefab;
    public GameObject handObject;
    public List<GameObject> newCardAdd;
    public GameObject newCard;
    public bool drawn = false;
    void Start()
    {
        transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
    }
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        draw();
    }
    public void draw()
    {
        newCardAdd.Remove(newCard);
        newCard = Instantiate(cardPrefab, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity) as GameObject;
        newCard.transform.parent = handObject.transform;
        newCardAdd.Add(newCard);
        drawn = true;
    }
}
