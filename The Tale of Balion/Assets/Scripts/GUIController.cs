using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    public GameObject gameplay;
    public GameObject smallGameMenu;

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
                CurrentGameState.IsGameplayTurnedOn = false;
                CurrentGameState.SmallGameMenu      = true;
                gameplay.SetActive(CurrentGameState.IsGameplayTurnedOn);
                smallGameMenu.SetActive(CurrentGameState.SmallGameMenu);
            }
        }
        else 
        {
            if (CurrentGameState.SmallGameMenu)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    CurrentGameState.IsGameplayTurnedOn = true;
                    CurrentGameState.SmallGameMenu      = false;
                    gameplay.SetActive(CurrentGameState.IsGameplayTurnedOn);
                    smallGameMenu.SetActive(CurrentGameState.SmallGameMenu);
                }
            }
        }
    }
}
