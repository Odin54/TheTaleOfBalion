using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofDisappearing : MonoBehaviour
{
    private SpriteRenderer RoofLayer;

    public float EnterOpacity;     //0.3
    public float LeaveOpacity;     //1

    void Start()
    {
        RoofLayer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D()
    {
        RoofLayer.color = new Color (1f, 1f, 1f, EnterOpacity);
    }
        private void OnTriggerExit2D()
    {
        RoofLayer.color = new Color (1f, 1f, 1f, LeaveOpacity);
    }

}
