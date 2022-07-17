using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManagerMainMenu : MonoBehaviour
{
    public void startGame(){
        SceneManager.LoadScene("level");
    }

    public void quitGame(){
        Application.Quit();
    }
}
