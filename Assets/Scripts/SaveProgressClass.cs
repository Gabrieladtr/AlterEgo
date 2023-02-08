using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SaveProgressClass : MonoBehaviour
{
    //O objetivo dessa classe é salvar o progresso do jogador e acessar esse progresso atraves de metodos, de forma dinâmica.


    //Variaveis par armazenar os saves/nomes dos saves criados pelo jogador:

    public string save1 = null, save2 = null, save3 = null;
    //esses ficam dentro da classe de loading
    public TMP_Text save1TMP = null, save2TMP = null, save3TMP = null;
    //esses ficam dentro da classe de saving
    public TMP_Text saving1TMP = null, saving2TMP = null, saving3TMP = null;

    //Criamos um objto da classe Game para acessar o valor da variavel original 'escolhaDialogica'.
    public Game game;
    
    public string escolhaSaveGame;


    //Nome da minha variável onde eu guardei o valor da minha lista de frases atual.
    //É a partir dela que vamos poder carregar/salvar o progresso do jogador.
    //escolhaDialogica

    //Acabei de me dar conta de que precisamos criar um sistema que grava quais escolhas o jogador fez
    //Será usado para definir apenas o final, uma vez que o sistema de rotas de lista de frases está pronto.

    /*
    private void Start()
    {
        game = new Game();
        //game = GetComponent<Game>();
    }


    public void Save1Progress()
    {
        //save1 = game.escolhaDialogica;

        save1 = game.escolhaDialogica;
        PlayerPrefs.SetString("Save1", save1);

        //vai trazer para a cena Saving os nomes dos saves. 
        saving1TMP = GameObject.Find("SalvarProgressoGameTMP").GetComponent<TMP_Text>();
        saving1TMP.text = "Save 1: " + save1;

        Debug.Log("Jogo salvo no slot 1. Nome do save: " + save1);

    }   


    public void LoadSave1()
    {
        //vai carregar o progresso do 1° save do jogador
        PlayerPrefs.GetString("save1", "O save 1 foi carregado.");
        
    }

    */

}
