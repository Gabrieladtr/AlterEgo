using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    //Essa classe controla se o pause esta ativado ou nao
    //Eu ativei essa classe dentro do background da cena do game. Dessa forma, o pause so funcina dentro do jogo.

    public bool pauseActive = false;    


    
    void Update()
    {

        //controlamos se o pause esta ativo ou nao

        if (Input.GetKeyDown(KeyCode.Escape) && pauseActive == false)
        {
            Debug.Log("O menu de pausa deve ser aberto.");
            SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
            pauseActive = true;

        } else if (Input.GetKeyDown(KeyCode.Escape) && pauseActive == true)
        {

            Debug.Log("O menu de pausa deve ser fechado.");
            SceneManager.UnloadSceneAsync("PauseMenu", UnloadSceneOptions.None);
            pauseActive = false;


        }


    }
}
