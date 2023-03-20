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


    public static bool avatarBoolCao = false, avatarBoolRaposa = false, avatarBoolPassaro = false,avatarBoolCoruja = false;

    public static void AvatarsOnScreen()
    {
        //Deve mostrar um avatar na tela, de acordo com o TMP_dialogo.
        //Se o dialogo come�ar com um nome, deve mostrar o avatar desse nome e desativar os outros.

        //Pega o texto que est� na tela e adiciona em 'TMP_tela2'
        


        //Faz uma comparacao, se o dialogo na tela comecar com algum desses nomes, deve mostrar o avatar desse nome.
        if (Game.textMeshProTela.text.Contains("Cão (Yael)") && SceneManager.GetActiveScene().name == "Game" && avatarBoolCao == false)
        {
            Debug.Log("Cão (Yael) esta na tela");
            avatarBoolCao = true;
            avatarBoolRaposa = false;
            avatarBoolPassaro = false;
            avatarBoolCoruja = false;


        
        }else if (Game.textMeshProTela.text.Contains("Raposa (Melinda)") && SceneManager.GetActiveScene().name == "Game"&& avatarBoolRaposa == false)
        {
            Debug.Log("Raposa (Melinda) esta na tela");
            avatarBoolCao = false;
            avatarBoolRaposa = true;
            avatarBoolPassaro = false;
            avatarBoolCoruja = false;

        }

        else if (Game.textMeshProTela.text.Contains("Pássaro (Wing)") && SceneManager.GetActiveScene().name == "Game"&& avatarBoolPassaro == false)
        {
            
            Debug.Log("Pássaro (Wing) esta na tela");
            avatarBoolCao = false;
            avatarBoolRaposa = false;
            avatarBoolPassaro = true;
            avatarBoolCoruja = false;

        }

        else if (Game.textMeshProTela.text.Contains("Coruja (Jones)") && SceneManager.GetActiveScene().name == "Game"&& avatarBoolCoruja == false)
        {
            Debug.Log("Coruja (Jones) esta na tela");
            avatarBoolCao = false;
            avatarBoolRaposa = false;
            avatarBoolPassaro = false;
            avatarBoolCoruja = true;

        }






    }






}
