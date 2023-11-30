using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ExampleClass : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{   
    public GameObject barText;

    void Start()
    {
        barText.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        barText.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("The cursor exit the selectable UI element.");
        barText.SetActive(false);
    }
}