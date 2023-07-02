using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    //Essa classe controla se o pause esta ativado ou nao
    //Eu ativei essa classe dentro do background da cena do game/main menu. Dessa forma, o pause so funcina dentro do jogo.

    public static bool pauseActive = false;    


    
    void Update()
    {

        //controlamos se o pause esta ativo ou nao
        DesativaPauseNoMenuPrincipal();

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Debug.Log("O Esc foi pressionado, pauseActive: " + pauseActive + ", Cena atual: " + SceneManager.GetActiveScene().name +
                ", StartGame.CenaAditivaAtual: " + StartGame.CenaAditivaAtual);

            if(pauseActive == false && SceneManager.GetActiveScene().name != "MainMenu" && StartGame.CenaAditivaAtual == null){
                    Debug.Log("O menu de pausa deve ser aberto.");
                    SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
                    Debug.Log("Cena atual: " + SceneManager.GetActiveScene().name);
                    pauseActive = true;

            }else if(pauseActive == true && SceneManager.GetActiveScene().name != "MainMenu" && StartGame.CenaAditivaAtual == null){
                    Debug.Log("O menu de pausa deve ser fechado.");
                    SceneManager.UnloadSceneAsync("PauseMenu", UnloadSceneOptions.None);
                    pauseActive = false;
            }


        }

        
        

    }



    public static void DesativaPauseNoMenuPrincipal()
    {
        //Quando vamos para o menu principal a partir do menu de pause, vai ser ativado esse metodo
        //dentro do background do menu principal que desativa o pauseActive permitindo que o jogador possa apertar Esc quantas vezes quiser.

        //vai desativar o pause em todas as cenas onde nao seja a cena de game. Entao nenhuam cena podera chamar o pause se 
        //esse metodo for chamadado. Isso inclui o menu principal.
        if(pauseActive == true && SceneManager.GetActiveScene().name == "MainMenu")
        {
            StartGame.CenaAditivaAtual = null;
            pauseActive = false;
            Debug.Log("O menu de pausa deve ser fechado a partir do menu principal. pauseActive =" + pauseActive);
            

        }
    }


}
