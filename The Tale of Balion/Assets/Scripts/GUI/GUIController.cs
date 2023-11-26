using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    public GameObject gameplay;
    public GameObject smallGameMenu;

    public void CloseSmallGameMenu()
    {
        CurrentGameState.IsGameplayTurnedOn = true;
        CurrentGameState.SmallGameMenu      = false;
        gameplay.SetActive(CurrentGameState.IsGameplayTurnedOn);
        smallGameMenu.SetActive(CurrentGameState.SmallGameMenu);
    }

    public void OpenSmallGameMenu()
    {
        CurrentGameState.IsGameplayTurnedOn = false;
        CurrentGameState.SmallGameMenu      = true;
        gameplay.SetActive(CurrentGameState.IsGameplayTurnedOn);
        smallGameMenu.SetActive(CurrentGameState.SmallGameMenu);
    }

    void Start()
    {
        smallGameMenu.SetActive(CurrentGameState.SmallGameMenu);
    }

    void Update()
    {
        if (CurrentGameState.IsGameplayTurnedOn)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                OpenSmallGameMenu();
            }
        }
        else 
        {
            if (CurrentGameState.SmallGameMenu)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    CloseSmallGameMenu();
                }
            }
        }
    }
}
