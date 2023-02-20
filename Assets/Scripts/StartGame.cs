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


        //Deve chamar a classe Game e inputar true no bool 'escolhaDialogicaBool' que adiciona um valor padrão em 'escolhaDialogica'
        //Isso significa que toda vez que o jogador iniciar o jogo no botao 'iniciar', ele vai iniciar com uma frase padrao
        //Sem gerar exceptions, multiplicar as frases que devem aparecer ou flodar o console.

        //Se o jogador iniciar dando um loadgame, toda essa funcao eh ignorada.

        if (Game.escolhaDialogicaBool == false && stageToPlay == "Game")
        {
                Game.escolhaDialogicaBool = true;
                
        }

    }

    public void selectSceneAdditive(string stageToPlay)
    {
        SceneManager.LoadScene(stageToPlay, LoadSceneMode.Additive);
    }



}
