using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    
    

    public void CloseScene(string stageToClose)
    {
        SceneManager.UnloadSceneAsync(stageToClose, UnloadSceneOptions.None);
        
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
