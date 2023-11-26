using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToSettingsButton : MonoBehaviour
{
    public GameObject settings;
    public GameObject smallGameMenu;

    public void ToSettings()
    {
        settings.SetActive(true);
        smallGameMenu.SetActive(false);
    }
}
