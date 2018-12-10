using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

    public bool gameHasEnded;
    public float restartDelay = 2f;
    public GameObject CompleteUI;
    public void CompleteLevel()
    {
        CompleteUI.SetActive(true);
        Debug.Log("Level Completed");
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("restart", restartDelay);
        }
        
        
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
