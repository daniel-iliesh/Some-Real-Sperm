using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{

    public Animator animator;
    public float delay = 1.15f;

    public void StartGame() {
        animator.SetBool("gameIsBegin", true);
        StartCoroutine(LoadLevelAfterDelay(delay));
        /*SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);*/
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}


