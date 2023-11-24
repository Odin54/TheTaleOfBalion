// using UnityEngine;
// using System.Collections;

// public class UserInterface : MonoBehaviour
// {

//     public enum CanvasStates
//     {
//         gameplay,
//         smallGameMenu,
//     }

//     internal CanvasStates canvasState;


//     public GameObject GameplayCanvas;
//     public GameObject SmallGameMenuCanvas;


//     // This method will remain active one cavas at a time just pass the state like
//     /*Example
//     public void Example(){
//         SetCanvasState (UserInterface.CanvasStates.smallGameMenu);
//     }
//     */
//     public static void SetCanvasState(CanvasStates state){
//         GameplayCanvas.SetActive(state == CanvasStates.gameplay);
//         SmallGameMenuCanvas.SetActive(state == CanvasStates.smallGameMenu);
//     }

// }