using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{

    public Button ficarButton,SairMesmoButton;
    public Image sairBackground;
    public TMP_Text tituloGame;

    public string stateOfSair;



    public void QuitApplication() 
    {
        //sai da aplicacao
        Debug.Log("Application quit");
        Application.Quit();
    }

    private void Start()
    {
        //inicializa os elementos da tela

        if(GameObject.Find("SimMesmo") || GameObject.Find("Ficar") || GameObject.Find("SairBackground") || GameObject.Find("TituloSair"))
        {
            
            SairMesmoButton = GameObject.Find("SimMesmo").GetComponent<Button>();
            ficarButton = GameObject.Find("Ficar").GetComponent<Button>();
            sairBackground = GameObject.Find("SairBackground").GetComponent<Image>();
            tituloGame = GameObject.Find("TituloSair").GetComponent<TMP_Text>();

            //ativa ou desativa os elementos na tela
            InicialiarTelaSair(true);

        }
        
    }




    public void InicialiarTelaSair(bool ligadoOuNao)
    {
        //Por padr�o vai inicializar a cena com os botoes desligados
        sairBackground.gameObject.SetActive(ligadoOuNao);
        SairMesmoButton.gameObject.SetActive(ligadoOuNao);
        ficarButton.gameObject.SetActive(ligadoOuNao);
        tituloGame.gameObject.SetActive(ligadoOuNao);

    }



    public void WantGetOff(string state)
    {
        //define um estado para verificar se os botoes ficam ou nao na tela
        stateOfSair = state;

        //Vai ter 3 fun��es: sair, sair mesmo ou ficar.
        switch (stateOfSair)
        {
            case "SairMesmo":
                //Se o jogador clicar me 'desconectar', sair� do aplicativo
                QuitApplication();
                break;

            case "Ficar":
                //fecha a tela que abriu e volta ao menu inicial
                SceneManager.UnloadSceneAsync("QuerMesmoSair", UnloadSceneOptions.None);
                break;

            default:
                Debug.Log("Selecione um estado para prosseguir");
                break;

        }
    }


}

