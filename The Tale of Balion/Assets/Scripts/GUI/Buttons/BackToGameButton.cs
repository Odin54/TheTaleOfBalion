using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToGameButton : MonoBehaviour
{
    public GameObject gameplay;
    public GameObject smallGameMenu;

    public void BackToGame()
    {
        CurrentGameState.IsGameplayTurnedOn = true;
        CurrentGameState.SmallGameMenu      = false;
        gameplay.SetActive(CurrentGameState.IsGameplayTurnedOn);
        smallGameMenu.SetActive(CurrentGameState.SmallGameMenu);
    }
}
