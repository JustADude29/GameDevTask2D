using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    public GameObject gamerOverCanvas;
    public GameObject spawner;

    private void start(){
        Time.timeScale = 1;
    }

    public void GameOver(){
        gamerOverCanvas.SetActive(true);
        spawner.SetActive(false);
        Time.timeScale = 0;
        if(scoremodifier1.score>PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore", scoremodifier1.score);
        }
        
    }

    public void restart(){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
        scoremodifier1.score = 0;
    }

    public void quit(){
        Debug.Log("quit button");
        SceneManager.LoadScene("Main Menu");
    }


    
}
