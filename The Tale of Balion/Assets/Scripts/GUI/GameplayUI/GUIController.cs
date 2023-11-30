using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    public GameObject gameplayCanvas;
    public GameObject smallGameMenuCanvas;
    public GameObject smallGameMenuSettings;
    public GameObject smallGameMenu;

    public void CloseSmallGameMenu()
    {
        CurrentGameState.IsGameplayTurnedOn = true;
        CurrentGameState.SmallGameMenu      = false;
        gameplayCanvas.SetActive(CurrentGameState.IsGameplayTurnedOn);
        smallGameMenuCanvas.SetActive(CurrentGameState.SmallGameMenu);
    }

    public void OpenSmallGameMenu()
    {
        CurrentGameState.IsGameplayTurnedOn = false;
        CurrentGameState.SmallGameMenu      = true;
        gameplayCanvas.SetActive(CurrentGameState.IsGameplayTurnedOn);
        smallGameMenu.SetActive(true);
        smallGameMenuSettings.SetActive(false);
        smallGameMenuCanvas.SetActive(CurrentGameState.SmallGameMenu);
    }

    void Start()
    {
        smallGameMenuCanvas.SetActive(CurrentGameState.SmallGameMenu);
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
