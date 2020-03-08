using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDrag : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {

        }
    }
}
