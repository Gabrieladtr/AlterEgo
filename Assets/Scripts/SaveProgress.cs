using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveProgressClass : MonoBehaviour
{
    //Saves criados pelo jogador:

    public string save1 = null, save2 = null, save3 = null;

    //Nome da minha variável onde eu guardei o valor da minha lista de frases atual.
    //É a partir dela que vamos poder carregar/salvar o progresso do jogador.
    //escolhaDialogica

    //Acabei de me dar conta de que precisamos criar um sistema que grava quais escolhas o jogador fez
    //Será usado para definir apenas o final, uma vez que o sistema de rotas de lista de frases está pronto.



    public void SaveProgress(string escolhaDialogicaSave)
    {
        //vai salvar o progresso do jogador
        save1 = escolhaDialogicaSave;
        PlayerPrefs.SetString("save1", save1);
        
    
    }


    public void LoadSave()
    {
        //vai carregar o progresso do jogador
        PlayerPrefs.GetString("save1", "O save 1 foi carregado.");
    }

}
