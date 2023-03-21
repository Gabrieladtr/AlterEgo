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


    public static bool avatarBoolCao = false, avatarBoolRaposa = false, avatarBoolPassaro = false,avatarBoolCoruja = false, chaveGeral = false;
    public static Image avatarlCao, avatarlRaposa, avatarlPassaro, avatarlCoruja, avatarlLIA, avatarlMalev, avatarlLinda, avatarlAsimov;


    public static void AvatarsOnScreen()
    {
        //Deve mostrar um avatar na tela, de acordo com o TMP_dialogo.
        //Se o dialogo come�ar com um nome, deve mostrar o avatar desse nome e desativar os outros.

        //Pega o texto que est� na tela e adiciona em 'TMP_tela2'


        avatarlCao = GameObject.Find("Cão (Yael)").GetComponent<Image>();
        avatarlRaposa = GameObject.Find("Raposa (Melinda)").GetComponent<Image>();
        avatarlPassaro = GameObject.Find("Wing").GetComponent<Image>();
        avatarlCoruja = GameObject.Find("Coruja (Jones)").GetComponent<Image>();
        avatarlLIA = GameObject.Find("L.I.A.").GetComponent<Image>();
        avatarlMalev = GameObject.Find("Malev").GetComponent<Image>();
        avatarlLinda = GameObject.Find("Linda").GetComponent<Image>();
        avatarlAsimov = GameObject.Find("Asimovitsky").GetComponent<Image>();


        /*
        avatarlCao.enabled = false;

        avatarlRaposa.enabled = false;
        avatarlPassaro.enabled = false;
        avatarlCoruja.enabled = false;
        avatarlLIA.enabled = false;
        avatarlMalev.enabled = false;
        avatarlLinda.enabled = false;
        avatarlAsimov.enabled = false;

        
        avatarlCao.gameObject.SetActive(true);
        avatarlRaposa.gameObject.SetActive(true);
        avatarlPassaro.gameObject.SetActive(true);
        avatarlCoruja.gameObject.SetActive(true);
        avatarlLIA.gameObject.SetActive(true);
        avatarlMalev.gameObject.SetActive(true);
        avatarlLinda.gameObject.SetActive(true);
        avatarlAsimov.gameObject.SetActive(true);
        */





        //Faz uma comparacao, se o dialogo na tela comecar com algum desses nomes, deve mostrar o avatar desse nome.
        if (Game.textMeshProTela.text.Contains("Cão (Yael)") && SceneManager.GetActiveScene().name == "Game" && avatarBoolCao == false)
        {

            Debug.Log("Cão (Yael) esta na tela");
            avatarlRaposa.enabled = chaveGeral;
            avatarlPassaro.enabled = chaveGeral;
            avatarlCoruja.enabled = chaveGeral;
            avatarlLIA.enabled = chaveGeral;
            avatarlMalev.enabled = chaveGeral;
            avatarlLinda.enabled = chaveGeral;
            avatarlAsimov.enabled = chaveGeral;
            avatarlCao.enabled = true;
            avatarBoolCao = true;
            avatarBoolRaposa = false;
            avatarBoolPassaro = false;
            avatarBoolCoruja = false;

            

        }
        else if (Game.textMeshProTela.text.Contains("Raposa (Melinda)") && SceneManager.GetActiveScene().name == "Game" && avatarBoolRaposa == false && avatarlRaposa.enabled == false)
        {
                

                Debug.Log("Raposa (Melinda) esta na tela");
                avatarlCao.enabled = chaveGeral;
                avatarlPassaro.enabled = chaveGeral;
                avatarlCoruja.enabled = chaveGeral;
                avatarlLIA.enabled = chaveGeral;
                avatarlMalev.enabled = chaveGeral;
                avatarlLinda.enabled = chaveGeral;
                avatarlAsimov.enabled = chaveGeral;
                avatarlRaposa.enabled = true;
                avatarBoolCao = false;
                avatarBoolRaposa = true;
                avatarBoolPassaro = false;
                avatarBoolCoruja = false;

            
            
        }

        else if (Game.textMeshProTela.text.Contains("Wing (Pássaro) ") && SceneManager.GetActiveScene().name == "Game" && avatarBoolPassaro == false)
        {

            
            Debug.Log("Pássaro (Wing) esta na tela");
            avatarlPassaro.enabled = true;
            avatarlCao.enabled = chaveGeral;
            avatarlRaposa.enabled = chaveGeral;
            avatarlCoruja.enabled = chaveGeral;
            avatarlLIA.enabled = chaveGeral;
            avatarlMalev.enabled = chaveGeral;
            avatarlLinda.enabled = chaveGeral;
            avatarlAsimov.enabled = chaveGeral;
            avatarBoolCao = false;
            avatarBoolRaposa = false;
            avatarBoolPassaro = true;
            avatarBoolCoruja = false;


        }

        else if (Game.textMeshProTela.text.Contains("Coruja (Jones)") && SceneManager.GetActiveScene().name == "Game" && avatarBoolCoruja == false)
        {

            Debug.Log("Coruja (Jones) esta na tela");
            avatarlCoruja.enabled = true;
            avatarlCao.enabled = chaveGeral;
            avatarlRaposa.enabled = chaveGeral;
            avatarlPassaro.enabled = chaveGeral;
            avatarlLIA.enabled = chaveGeral;
            avatarlMalev.enabled = chaveGeral;
            avatarlLinda.enabled = chaveGeral;
            avatarlAsimov.enabled = chaveGeral;
            avatarBoolCao = false;
            avatarBoolRaposa = false;
            avatarBoolPassaro = false;
            avatarBoolCoruja = true;
        }
        else if(!Game.textMeshProTela.text.Contains("Coruja (Jones)") && !Game.textMeshProTela.text.Contains("Pássaro (Wing)") &&
            !Game.textMeshProTela.text.Contains("Raposa (Melinda)") && !Game.textMeshProTela.text.Contains("Cão (Yael)")
                && SceneManager.GetActiveScene().name == "Game")
        {

            
            Debug.Log("Não deve mostrar nenhum avatar na tela");
            avatarlCao.enabled = false;
            avatarlRaposa.enabled = false;
            avatarlPassaro.enabled = false;
            avatarlCoruja.enabled = false;
            avatarlLIA.enabled = false;
            avatarlMalev.enabled = false;
            avatarlLinda.enabled = false;
            avatarlAsimov.enabled = false;
            /*
            avatarBoolCao = false;
            avatarBoolRaposa = false;
            avatarBoolPassaro = false;
            avatarBoolCoruja = false;
            */

        }






    }






}
