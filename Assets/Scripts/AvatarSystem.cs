using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AvatarSystem : MonoBehaviour
{

    //Image Cao, Raposa, Coruja, Passaro, Linda, LIA, Malev, Asimov;
    //public static TMP_Text TMP_tela;






    public static void AvatarsOnScreen()
    {
        //Deve mostrar um avatar na tela, de acordo com o TMP_dialogo.
        //Se o dialogo come�ar com um nome, deve mostrar o avatar desse nome e desativar os outros.

        //Pega o texto que est� na tela e adiciona em 'TMP_tela2'
        


        //Faz uma comparacao, se o dialogo na tela comecar com algum desses nomes, deve mostrar o avatar desse nome.
        if (Game.textMeshProTela.text.Contains("C�o (Yael)") && SceneManager.GetActiveScene().name == "Game")
        {
            Debug.Log("C�o (Yael) est� na tela");
        
        }else if (Game.textMeshProTela.text.Contains("Raposa (Melinda)") && SceneManager.GetActiveScene().name == "Game")
        {
            Debug.Log("Raposa (Melinda) est� na tela");

        }

        else if (Game.textMeshProTela.text.Contains("P�ssaro (Wing)") && SceneManager.GetActiveScene().name == "Game")
        {
            Debug.Log("P�ssaro (Wing) est� na tela");

        }

        else if (Game.textMeshProTela.text.Contains("Coruja (Jones)") && SceneManager.GetActiveScene().name == "Game")
        {
            Debug.Log("Coruja (Jones) est� na tela");

        }






    }






}
