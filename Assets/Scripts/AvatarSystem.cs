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


    public static bool chaveGeral = false, chaveGeral2_trava_ao_nao_ter_avatar_na_tela = false;
    public static Image avatarlCao, avatarlRaposa, avatarlPassaro, avatarlCoruja, avatarlLIA, avatarlMalev, avatarlLinda, avatarlAsimov;




    public static void AvatarsOnScreen()
    {
        //Deve mostrar um avatar na tela, de acordo com o TMP_dialogo.
        //Se o dialogo come�ar com um nome, deve mostrar o avatar desse nome e desativar os outros.

        //Pega o texto que est� na tela e adiciona em 'TMP_tela2'


        avatarlCao = GameObject.Find("Cão (Yael)").GetComponent<Image>();
        avatarlRaposa = GameObject.Find("Raposa (Melinda)").GetComponent<Image>();
        avatarlPassaro = GameObject.Find("Wing (Pássaro)").GetComponent<Image>();
        avatarlCoruja = GameObject.Find("Coruja (Jones)").GetComponent<Image>();
        avatarlLIA = GameObject.Find("L.I.A.").GetComponent<Image>();
        avatarlMalev = GameObject.Find("Malev").GetComponent<Image>();
        avatarlLinda = GameObject.Find("Linda").GetComponent<Image>();
        avatarlAsimov = GameObject.Find("Asimovitsky").GetComponent<Image>();




        //Faz uma comparacao, se o dialogo na tela comecar com algum desses nomes, deve mostrar o avatar desse nome.
        if (Game.textMeshProTela.text.Contains("Cão (Yael)") && SceneManager.GetActiveScene().name == "Game" && avatarlCao.enabled == chaveGeral)
        {
            /**/
            Debug.Log("Cão (Yael) esta na tela");
            avatarlCao.enabled = true;

            avatarlRaposa.enabled = chaveGeral;
            avatarlPassaro.enabled = chaveGeral;
            avatarlCoruja.enabled = chaveGeral;
            avatarlLIA.enabled = chaveGeral;
            avatarlMalev.enabled = chaveGeral;
            avatarlLinda.enabled = chaveGeral;
            avatarlAsimov.enabled = chaveGeral;
            chaveGeral2_trava_ao_nao_ter_avatar_na_tela = false;


        }
        else if (Game.textMeshProTela.text.Contains("Raposa (Melinda)") && SceneManager.GetActiveScene().name == "Game" && avatarlRaposa.enabled == chaveGeral)
        {
            /* && */

            Debug.Log("Raposa (Melinda) esta na tela");


            avatarlRaposa.enabled = true;

            avatarlCao.enabled = chaveGeral;
            avatarlPassaro.enabled = chaveGeral;
            avatarlCoruja.enabled = chaveGeral;
            avatarlLIA.enabled = chaveGeral;
            avatarlMalev.enabled = chaveGeral;
            avatarlLinda.enabled = chaveGeral;
            avatarlAsimov.enabled = chaveGeral;
            chaveGeral2_trava_ao_nao_ter_avatar_na_tela = false;


        }


        if (Game.textMeshProTela.text.Contains("Wing (Pássaro)") || Game.textMeshProTela.text.Contains("Pássaro –") && SceneManager.GetActiveScene().name == "Game" && avatarlPassaro.enabled == chaveGeral)
        {
            /**/
            Debug.Log("Passaro esta na tela");
            avatarlPassaro.enabled = true;


            avatarlCao.enabled = chaveGeral;
            avatarlRaposa.enabled = chaveGeral;
            avatarlCoruja.enabled = chaveGeral;
            avatarlLIA.enabled = chaveGeral;
            avatarlMalev.enabled = chaveGeral;
            avatarlLinda.enabled = chaveGeral;
            avatarlAsimov.enabled = chaveGeral;
            chaveGeral2_trava_ao_nao_ter_avatar_na_tela = false;

        }

        else if (Game.textMeshProTela.text.Contains("Coruja (Jones)") || Game.textMeshProTela.text.Contains("Coruja –") && SceneManager.GetActiveScene().name == "Game" && avatarlCoruja.enabled == chaveGeral)
        {
            /* */
            Debug.Log("Coruja (Jones) esta na tela");
            avatarlCoruja.enabled = true;

            avatarlCao.enabled = chaveGeral;
            avatarlRaposa.enabled = chaveGeral;
            avatarlPassaro.enabled = chaveGeral;
            avatarlLIA.enabled = chaveGeral;
            avatarlMalev.enabled = chaveGeral;
            avatarlLinda.enabled = chaveGeral;
            avatarlAsimov.enabled = chaveGeral;
            chaveGeral2_trava_ao_nao_ter_avatar_na_tela = false;

        }
        else if (Game.textMeshProTela.text.Contains("Linda – ") && SceneManager.GetActiveScene().name == "Game" /*&& avatarlLinda.enabled == chaveGeral*/)
        {

            /**/
            Debug.Log("Linda esta na tela");

            avatarlLinda.enabled = true;

            avatarlRaposa.enabled = chaveGeral;
            avatarlCao.enabled = chaveGeral;
            avatarlPassaro.enabled = chaveGeral;
            avatarlCoruja.enabled = chaveGeral;
            avatarlLIA.enabled = chaveGeral;
            avatarlMalev.enabled = chaveGeral;
            avatarlAsimov.enabled = chaveGeral;
            chaveGeral2_trava_ao_nao_ter_avatar_na_tela = false;


        }
        else if (Game.textMeshProTela.text.Contains("Malev –") && SceneManager.GetActiveScene().name == "Game" && avatarlMalev.enabled == chaveGeral)
        {

            /**/
            Debug.Log("Malev esta na tela");


            avatarlMalev.enabled = true;

            avatarlLinda.enabled = chaveGeral;
            avatarlRaposa.enabled = chaveGeral;
            avatarlCao.enabled = chaveGeral;
            avatarlPassaro.enabled = chaveGeral;
            avatarlCoruja.enabled = chaveGeral;
            avatarlLIA.enabled = chaveGeral;
            avatarlAsimov.enabled = chaveGeral;
            chaveGeral2_trava_ao_nao_ter_avatar_na_tela = false;


        }
        else if (Game.textMeshProTela.text.Contains("L.I.A. –") && Game.textMeshProTela.text.Contains("Asimovitsky") && SceneManager.GetActiveScene().name == "Game" && avatarlLIA.enabled == chaveGeral && avatarlAsimov.enabled == chaveGeral)
        {
            /**/

            //Deve mostrar LIA junto com o Asimovitsky, quando for necessário
            Debug.Log("Deve mostrar LIA junto com o Asimovitsky na tela");

            avatarlLIA.enabled = true;
            avatarlAsimov.enabled = true;

            avatarlMalev.enabled = chaveGeral;
            avatarlLinda.enabled = chaveGeral;
            avatarlRaposa.enabled = chaveGeral;
            avatarlCao.enabled = chaveGeral;
            avatarlPassaro.enabled = chaveGeral;
            avatarlCoruja.enabled = chaveGeral;
            chaveGeral2_trava_ao_nao_ter_avatar_na_tela = false;



        }
        else if (Game.textMeshProTela.text.Contains("L.I.A. -") && SceneManager.GetActiveScene().name == "Game")
        {
            /**/

            //Deve mostrar LIA 
            Debug.Log("LIA esta na tela");

            avatarlLIA.enabled = true;
            avatarlAsimov.enabled = chaveGeral;

            avatarlMalev.enabled = chaveGeral;
            avatarlLinda.enabled = chaveGeral;
            avatarlRaposa.enabled = chaveGeral;
            avatarlCao.enabled = chaveGeral;
            avatarlPassaro.enabled = chaveGeral;
            avatarlCoruja.enabled = chaveGeral;
            chaveGeral2_trava_ao_nao_ter_avatar_na_tela = false;



        }

        else if (!Game.textMeshProTela.text.Contains("Coruja (Jones)") && !Game.textMeshProTela.text.Contains("Pássaro (Wing)") &&
            !Game.textMeshProTela.text.Contains("Raposa (Melinda)") && !Game.textMeshProTela.text.Contains("Cão (Yael)")
            && !Game.textMeshProTela.text.Contains("L.I.A. -") && !Game.textMeshProTela.text.Contains("Asimovitsky")
            && !Game.textMeshProTela.text.Contains("Linda -") && !Game.textMeshProTela.text.Contains("Coruja –")
            && !Game.textMeshProTela.text.Contains("Pássaro –")
            && !Game.textMeshProTela.text.Contains("Malev –") && SceneManager.GetActiveScene().name == "Game"
            )
        {
            //Nao deve mostrar nenhum avatar, somente o texto na tela.

            avatarlCao.enabled = chaveGeral;
            avatarlRaposa.enabled = chaveGeral;
            avatarlPassaro.enabled = chaveGeral;
            avatarlCoruja.enabled = chaveGeral;
            avatarlLIA.enabled = chaveGeral;
            avatarlMalev.enabled = chaveGeral;
            avatarlLinda.enabled = chaveGeral;
            avatarlAsimov.enabled = chaveGeral;

            if (chaveGeral2_trava_ao_nao_ter_avatar_na_tela == false) {

                Debug.Log("Não deve mostrar nenhum avatar na tela");
                //vai permitir que nenhum avatar seja mostrado na tela a nao ser que atenda algum IF acima.
                
                chaveGeral2_trava_ao_nao_ter_avatar_na_tela = true;

            }




        }
        



    }






}
