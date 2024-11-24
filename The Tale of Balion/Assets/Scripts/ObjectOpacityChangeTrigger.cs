using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofDisappearing : MonoBehaviour
{
    private SpriteRenderer RoofLayer;

    [Range(0.0f, 1.0f)]
    public float EnterOpacity;     //0.3
    [Range(0.0f, 1.0f)]
    public float LeaveOpacity;     //1

    void Start()
    {
        RoofLayer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "Player")
        {
            RoofLayer.color = new Color (1f, 1f, 1f, EnterOpacity);
        }
    }
        private void OnTriggerExit2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "Player")
        {
            RoofLayer.color = new Color (1f, 1f, 1f, LeaveOpacity);
        }
    }

}
