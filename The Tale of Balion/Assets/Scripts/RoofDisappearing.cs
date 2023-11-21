using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofDisappearing : MonoBehaviour
{
    SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D()
    {
        sprite.color = new Color (1f, 1f, 1f, 0.3f);
    }
        private void OnTriggerExit2D()
    {
        sprite.color = new Color (1f, 1f, 1f, 1f);
    }

}
