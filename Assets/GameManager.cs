using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public GameObject sliderUI;

    public void CompleteLevel () {
        Debug.Log("LEVEL WON");
        completeLevelUI.SetActive(true);
        sliderUI.SetActive(false);
    }
    
    public void EndGame() {

        if(!gameHasEnded) {
        gameHasEnded = true;
        Debug.Log("GAME OVER!");
        Invoke("Restart", restartDelay);
        //Restart the Game

        }
        
    }
     void Restart() {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
}
