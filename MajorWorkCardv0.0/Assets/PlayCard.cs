using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCard: MonoBehaviour
{
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
            Destroy(gameObject);
        }
    }
}
