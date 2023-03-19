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
        //Se o dialogo começar com um nome, deve mostrar o avatar desse nome e desativar os outros.

        //Pega o texto que está na tela e adiciona em 'TMP_tela2'
        


        //Faz uma comparacao, se o dialogo na tela comecar com algum desses nomes, deve mostrar o avatar desse nome.
        if (Game.textMeshProTela.text.Contains("Cão (Yael)") && SceneManager.GetActiveScene().name == "Game")
        {
            Debug.Log("Cão (Yael) está na tela");
        
        }else if (Game.textMeshProTela.text.Contains("Raposa (Melinda)") && SceneManager.GetActiveScene().name == "Game")
        {
            Debug.Log("Raposa (Melinda) está na tela");

        }

        else if (Game.textMeshProTela.text.Contains("Pássaro (Wing)") && SceneManager.GetActiveScene().name == "Game")
        {
            Debug.Log("Pássaro (Wing) está na tela");

        }

        else if (Game.textMeshProTela.text.Contains("Coruja (Jones)") && SceneManager.GetActiveScene().name == "Game")
        {
            Debug.Log("Coruja (Jones) está na tela");

        }






    }






}
