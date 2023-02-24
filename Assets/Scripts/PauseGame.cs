using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    //Essa classe controla se o pause esta ativado ou nao
    //Eu ativei essa classe dentro do background da cena do game. Dessa forma, o pause so funcina dentro do jogo.

    public static bool pauseActive = false;    


    
    void Update()
    {

        //controlamos se o pause esta ativo ou nao

        if (Input.GetKeyDown(KeyCode.Escape) && pauseActive == false && SceneManager.GetActiveScene().name == "Game" && StartGame.CenaAditivaAtual == null)
        {
            Debug.Log("O menu de pausa deve ser aberto.");
            SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
            Debug.Log("Cena atual: " + SceneManager.GetActiveScene().name);
            pauseActive = true;

        } else if (Input.GetKeyDown(KeyCode.Escape) && pauseActive == true && SceneManager.GetActiveScene().name == "Game" && StartGame.CenaAditivaAtual == null)
        {

            Debug.Log("O menu de pausa deve ser fechado.");
            SceneManager.UnloadSceneAsync("PauseMenu", UnloadSceneOptions.None);
            pauseActive = false;


        }

        DesativaPauseNoMenuPrincipal();

    }



    public void DesativaPauseNoMenuPrincipal()
    {
        //Quando vamos para o menu principal a partir do menu de pause, vai ser ativado esse metodo
        //dentro do background do menu principal que desativa o pauseActive permitindo que o jogador possa apertar Esc quantas vezes quiser.
        if(pauseActive == true && SceneManager.GetActiveScene().name != "Game")
        {

            Debug.Log("O menu de pausa deve ser fechado a partir do menu principal.");
            pauseActive = false;

        }
    }


}
