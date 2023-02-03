using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public bool pauseActive = false;
    

    public void ClosePauseGame(string stageToClose)
    {
        SceneManager.UnloadSceneAsync(stageToClose, UnloadSceneOptions.None);
        pauseActive = false;
    }


    public void selectScene(string stageToPlay)
    {
        SceneManager.LoadScene(stageToPlay);
    }

    public void selectSceneAdditive(string stageToPlay)
    {
        SceneManager.LoadScene(stageToPlay, LoadSceneMode.Additive);
    }



}
