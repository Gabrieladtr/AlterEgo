using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    //Essa classe serve pra controlar os processos de links, abertura de cenas e fechamento de cenas.

    public static string CenaAtual;
    public static string cenaAnteriorString, CenaAtualString;
    public static bool DeveRetornarAoPause = false;
    public static string CenaAditivaAtual = null;



    public void CloseScene(string stageToClose)
    {
        //vai fechar uma cena.
        SceneManager.UnloadSceneAsync(stageToClose, UnloadSceneOptions.None);
        
    }
  

    public void SelectScene(string stageToPlay)
    {
        //Sera usado para carregar uma cena.
        //Nao deve ser usado para carregar loads do jogador, apenas cenas comuns.
        //Para evitar problemas, setamos um valor padrao em escolhaDialogicaBool.



        //identifica a cena atual e a anterior e se o pause esta ativo
        IdentificaCenaAtualEAnterior(stageToPlay);
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

        //Vamos verificar quando estamos linkando para qualquer cena (em especial dentro do 'pause', em 'loading' para 'Game')
        //Pq nesse caso especifico, na 'cenaAditivaAtual' pode ser atribuido um valor inutil, que acaba nao permitindo que eu acesse o menu
        //de pausa quando inicio o game por esse caminho, apenas quando entro pelo menu inicial.
        //Por isso vou zerar o 'cenaAditivaAtual', permitindo o acesso ao menu de pause.
        
        //Se vc for analisar, dentro do PauseGame, o sistema de pause so funciona quando o ''cenaAditivaAtual' esta nulo.
        //Entao se estivermos dentro de 'game', com 'PauseGame.pauseActive == true', entao devemos atribuir nulo aqui para o menu voltar a funfar.
        if (PauseGame.pauseActive == true && SceneManager.GetActiveScene().name == "Game" && CenaAditivaAtual != null)
        {
            //desligamos o pause, para ele poder ser acessado
            PauseGame.pauseActive = false;
            CenaAditivaAtual = null;
        }


    }



    




    public void LoadEscolhaDialogicaPorSlot(string slotParaCarramento)
    {
        //Esse metodo sera usado apenas para trazer a informacao salva no PlayerPrefs da escolhaDialogica
        //Justamente para Game.EscolhaDialogica. Dessa forma, vamos unir o metodo de loadScene com esse metodo
        //Fazendo com que a cena seja carregada com a escolhaDialogica escolhida.


        //vamos receber um slot e dependendo do Slot, o metodo vai carregar para a cena de Game a escolhaDialogica salva.
        switch(slotParaCarramento)
        {
            case "slot1":
                //vai carregar a escolhaDialogica salva no PlayerPrefs.
                
                Game.faseAtual3LoadGame = PlayerPrefs.GetString("Espaco1","Verificar StartGame");
                Debug.Log("O slot 1 carregado. EscolhaDialogica atual/(Game.faseAtual3LoadGame): " + Game.faseAtual3LoadGame);
                


            break;

            case "slot2":
                //vai carregar a escolhaDialogica salva no PlayerPrefs.

                Game.faseAtual3LoadGame = PlayerPrefs.GetString("Espaco2", "Verificar StartGame");
                Debug.Log("O slot 2 carregado. EscolhaDialogica atual/(Game.faseAtual3LoadGame):" + Game.faseAtual3LoadGame);
                

                break;

            case "slot3":
                //vai carregar a escolhaDialogica salva no PlayerPrefs.

                Game.faseAtual3LoadGame = PlayerPrefs.GetString("Espaco3", "Verificar StartGame");
                Debug.Log("O slot 3 carregado. EscolhaDialogica atual/(Game.faseAtual3LoadGame):" + Game.faseAtual3LoadGame);
                

                break;
        }

    }





    public void SelectSceneAdditive(string stageToPlay)
    {
        //vai abrir uma cena em cima de outra.

        //identifica a cena atual, a anterior e se o pause esta ativo
        IdentificaCenaAtualEAnterior(stageToPlay);
        //carrega a proxima cena de forma aditiva (por cima)
        SceneManager.LoadScene(stageToPlay, LoadSceneMode.Additive);


        //Vai dizer para a variavel de instancia qual cena aditiva foi carregada no momento.

        /*if (PauseGame.pauseActive == true)
        {
            CenaAditivaAtual = null;
        }
        else {
            
        }*/
        CenaAditivaAtual = stageToPlay;

    }


    //Preciso de um metodo que identifica qual cena estamos e para qual cena vamos 
    //ou qual cena estamos e qual foi a cena anterior.

    //se a cena atual for == a cena que vamos ir, entao o link vai nos levar para a msm cena.
    //se a cena que estou eh diferente da cena que vamos ir, entao a cena atual sera a cena anterior
    //e a cena que vamos ir sera a cena atual.

    public void IdentificaCenaAtualEAnterior(string proximaCena)
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


        //Nesse caso especifico, devemos inputar um valor padrao em "Game.escolhaDialogica" atraves do 'Game.escolhaDialogicaBool = true'
        if (cenaAnteriorString == "MenuLoading" && CenaAtualString == "Game" && Game.escolhaDialogicaBool == false && Game.faseAtual3LoadGame != null)
        {
            //Nesse caso especifico, quando carregamos uma escolhaDialogica salva no playerPrefs, e inputamos dentro de
            //'Game.escolhaDialogica', e viemos da tela de 'loading' para 'Game', precisamos reiniciar somente nesse caso o 'Game.faseAtual3LoadGame'.
            //Pq ai, se eu resolver sair para o menu principal e querer inicar um game novo, vou poder fazer isso sem ficar
            //com a minha escolhaDialogica salva. Dessa forma, vamos comecar o jogo com o valor padrao, alocado dentro do Game.Start().
            Game.escolhaDialogicaBool = true;

            //Reinicia o valor de 'faseAtual3LoadGame', para nao atrapalhar quando o jogador quiser iniciar por 'MenuInicial\InicarGame'.
            Game.faseAtual3LoadGame = null;

        }


    }

    public void RetornarCenaAnterior(string cenaPadraoVoltar)
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
            SceneManager.LoadScene(cenaPadraoVoltar);
            //vai permitir que eu volte a usar o pause menu, ao clicar no botao 'ficar logado' ao tentar sair do menu principal
            
            CenaAditivaAtual = null;
            
        }else{
            Debug.Log("Verifique o metodo RetornarCenaAnterior().");
        }

    }


    
}



