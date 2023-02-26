using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Notificacoes : MonoBehaviour
{
    //Essa classe servira para mostrar notificacoes na tela, para o jogador. (na cenas de confirmacao)
    //O foco eh apenas mostrar nofificacoes sobre o estado de save (se vai precisar salvar ou nao o jogo)

    TMP_Text textoNotificacao;


    void Start()
    {
        
        //textoNotificacao.gameObject.SetActive(false);
        MostrarNotificacao();
    }



    public void MostrarNotificacao()
    {
        //Esse metodo devera mostrar uma notificacao na tela, informando o estado de save.

        //Verifica se existe algum save novo criado nos ultimos minutos.
        SaveProgressClass.VerificaUltimoSave();

        //pega o componente de texto da cena 'QuerMesmoSair1'
        textoNotificacao = GameObject.Find("NotificacaoTMP").GetComponent<TMP_Text>();

        
        //faz a verificacao e mostra a msg na tela.
        if(SaveProgressClass.mostrarMsgNaTelaDesejaSalvar == true && PauseGame.pauseActive == true)
        {
            //textoNotificacao.gameObject.SetActive(true);
            textoNotificacao.text = "Aviso: vc nao salvou os dados do jogo nos ultimos 3 minutos...";


        }else if (SaveProgressClass.mostrarMsgNaTelaDesejaSalvar == false && PauseGame.pauseActive == true)
        {
            //textoNotificacao.SetActive(false);
            textoNotificacao.gameObject.SetActive(false);
            textoNotificacao.text = "Teste nao deve mostrar msg na tela";    

        }else if (SceneManager.GetActiveScene().name == "MainMenu"){
            textoNotificacao.gameObject.SetActive(false);

        }
        




    }


}
