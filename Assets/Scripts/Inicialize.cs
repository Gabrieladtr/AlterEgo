using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class Inicialize : MonoBehaviour
{

    public static TMP_Text saving1TMP, saving2TMP, saving3TMP;
    
    
    

    void Start()
    {
        //Verifica se os componentes estao na tela. Se sim, ele carrega os saves. Caso nao, ele nao carrega.



        if(GameObject.Find("Save1") == true && GameObject.Find("Save2") == true && GameObject.Find("Save3") == true
        && GameObject.Find("SaveLoading1_TMP") == true && GameObject.Find("SaveLoading2_TMP") == true && GameObject.Find("SaveLoading3_TMP") == true)
        {
            

            saving1TMP = GameObject.Find("SaveLoading1_TMP").GetComponent<TMP_Text>();
            saving1TMP.text = "Load 1: " + PlayerPrefs.GetString("Espaco1", "Nenhum save encontrado ") + " - Slot: Espaco 1";

            saving2TMP = GameObject.Find("SaveLoading2_TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Load 2: " + PlayerPrefs.GetString("Espaco2", "Nenhum save encontrado ") + " - Slot: Espaco 2";

            saving3TMP = GameObject.Find("SaveLoading3_TMP").GetComponent<TMP_Text>();
            saving3TMP.text = "Load 3: " + PlayerPrefs.GetString("Espaco3", " Nenhum save encontrado ") + " - Slot: Espaco 3";
            
            Debug.Log("Saves carregados na tela de loading com sucesso.");

        }else
        {
            Debug.Log("Algum dos componentes de texto/botoes nao foram encontrados na tela de LoadingMenu. Verifique para continuar.");

        }

    }





}
