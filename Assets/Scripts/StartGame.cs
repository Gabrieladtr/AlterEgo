using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    
    public static string CenaAtual;
    public static string cenaAnteriorString, CenaAtualString;
    public static bool DeveRetornarAoPause = false;
    public static string CenaAditivaAtual = null;



    public void CloseScene(string stageToClose)
    {
        //vai fechar uma cena.
        SceneManager.UnloadSceneAsync(stageToClose, UnloadSceneOptions.None);
        
    }
  

    public void selectScene(string stageToPlay)
    {
        //identifica a cena atual e a anterior e se o pause esta ativo
        identificaCenaAtualEAnterior(stageToPlay);
        //vai transportar o jogador para a proxima cena.
        SceneManager.LoadScene(stageToPlay);
        

        //Deve chamar a classe Game e inputar true no bool 'escolhaDialogicaBool' que adiciona um valor padrao em 'escolhaDialogica'
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
        //vai abrir uma cena em cima de outra.

        //identifica a cena atual, a anterior e se o pause esta ativo
        identificaCenaAtualEAnterior(stageToPlay);
        //carrega a proxima cena de forma aditiva (por cima)
        SceneManager.LoadScene(stageToPlay, LoadSceneMode.Additive);
        //Vai dizer para a variavel de instancia qual cena aditiva foi carregada no momento.
        CenaAditivaAtual = stageToPlay;


    }


    //Preciso de um metodo que identifica qual cena estamos e para qual cena vamos 
    //ou qual cena estamos e qual foi a cena anterior.

    //se a cena atual for == a cena que vamos ir, entao o link vai nos levar para a msm cena.
    //se a cena que estou eh diferente da cena que vamos ir, entao a cena atual sera a cena anterior
    //e a cena que vamos ir sera a cena atual.

    public void identificaCenaAtualEAnterior(string proximaCena)
    {
        cenaAnteriorString = SceneManager.GetActiveScene().name;
        CenaAtualString = proximaCena;

        if(cenaAnteriorString != proximaCena && PauseGame.pauseActive == false)
        {
            //Vai verificar se o pause esta ativo e qual a cena anterior e a proxima cena
            Debug.Log("A cena anterior eh: " + cenaAnteriorString + ". A cena atual agora eh: " + CenaAtualString + ". O pause esta: " + PauseGame.pauseActive);
            

        }else if(cenaAnteriorString != proximaCena && PauseGame.pauseActive == true)
        {
            //Vai verificar se o pause esta ativo e qual a cena anterior e a proxima cena
            Debug.Log("A cena anterior eh: " + cenaAnteriorString + ". A cena atual agora eh: " + CenaAtualString + ". O pause esta: " + PauseGame.pauseActive);
            
        }
        
        else if(cenaAnteriorString == proximaCena){

            Debug.Log("A cena anterior eh a mesma que a proxima");
        }else
        {
            Debug.Log("A cena atual eh totalmente diferente da proxima cena. Verificar.");
        }

    }

    public void RetornarCenaAnterior(string cenaVoltar)
    {
        //Esse metodo recebe uma cena como padrao, para onde ela deva ir normalmente.
        //Mas se por acaso o pause menu for aberto nesse caminho, ela deve retornar para essa cena.
        //Ou seja, controlamos 2 funcoes nesse metodo. 
        //Se a cena anterior for 'menu principal' e a proxima cena for 'como jogar', no botao de voltar devera voltar para 'menu principal'.
        //Se a cena anterior for 'Pause' e a proxima cena for 'como jogar', no botao de voltar devera voltar para 'Pause'.
        //Tudo em um mesmo botao.
        

        //Esse metodo deve controlar apenas o botao de voltar. Ele deve conseguir fechar uma cena aditiva e retornar para a cena anterior, usando o mesmo botao

        if(PauseGame.pauseActive == true)
        {
            //se eu tiver que retonar ao pause, devo apenas fechar a janela atual aberta de forma aditiva
            //Assim automaticamente ja estaremos dentro de Pause. Pq eh a cena anterior.
            SceneManager.UnloadSceneAsync(CenaAtualString, UnloadSceneOptions.None);

            
            //Enquanto essa variavel tiver valor, toda vez que uma tela for carregada de forma aditiva o pause nao podera ser invocado.
            //Atribuo para o 'CenaAditivaAtual' o valor null, pq dessa forma sendo ele null vai permitir que o menu de pause seja ativado.
            CenaAditivaAtual = null;

        }else if(PauseGame.pauseActive == false)
        {
            //Se o pause nao esta ativo, nos devemos apenas carregar a cena anterior.
            SceneManager.LoadScene(cenaVoltar);
        }else{
            Debug.Log("Verifique o metodo RetornarCenaAnterior().");
        }

    }


    
}



