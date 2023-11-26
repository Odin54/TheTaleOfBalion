using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToGameButton : MonoBehaviour
{
    public GameObject gameplayCanvas;
    public GameObject smallGameMenuCanvas;

    public void BackToGame()
    {
        CurrentGameState.IsGameplayTurnedOn = true;
        CurrentGameState.SmallGameMenu      = false;
        gameplayCanvas.SetActive(CurrentGameState.IsGameplayTurnedOn);
        smallGameMenuCanvas.SetActive(CurrentGameState.SmallGameMenu);
    }
}
