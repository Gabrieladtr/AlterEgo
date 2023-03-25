using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundSystem : MonoBehaviour
{
    /*
    //Nome de todas as artes no modo clássico de jogo:

    Arte da Capa do Game FHD_V2.1 - céu mais forte-FHD
    Arte da Capa do Game - Dia FHD V2-FHD
    Barraca novo v1-FHD
    Distrito de Testes - Arquivo FHD v2-FHD
    Campo FHD V2-FHD
    Blade FHD V1-FHD
    CyberCity Oficial V4-FHD

    Apartamento do Jones - V4 - Light off-FH
    Apartamento do Jones - V4 - Light on-FHD
    Diário v3-FHD
    Estação v12 - 13-8-FHD
    Estação v12 - 14-7 v2-FHD
    Mapa da cidade-Metro V3-FHD

    Prédio LIFE v4 - Final-FHD
    Welcome to SOV - linhas - Background - fundo-FHD
    Welcome to SOV - Password-FHD
    Welcome to SOV-FHD
    Arte de créditos v1-FHD     
     */


    public static string modoDeJogo = "Classic";

    public static bool chavePadraoBackground = false;

    public static Image acampamentoNoiteFHD, acampamentoDiaFHD, acampamentoBarracaFHD, distritoTestesFHD, campoFHD, bladeFHD, cybercityFHD,
        apJonesLightOffFHD, apJonesLightOnFHD, diarioFHD, estacao13_8FHD, estacao14_7FHD, mapaFHD, predioLifeFHD, WTS_backgroundFHD, WTS_PasswordFHD,
        WTS_FHD, creditosFHD;


    private void Start()
    {
        ShowBackgroundScene("bladeFHD", true);
    }


    public static void ShowBackgroundScene(string nomeBackground, bool setActive) 
    {

        //Instancio e pego as artes e coloco dentro das variaveis de imagem do game

        acampamentoNoiteFHD = GameObject.Find("acampamentoNoiteFHD").GetComponent<Image>();
        acampamentoDiaFHD = GameObject.Find("acampamentoDiaFHD").GetComponent<Image>();
        acampamentoBarracaFHD = GameObject.Find("acampamentoBarracaFHD").GetComponent<Image>();
        distritoTestesFHD = GameObject.Find("distritoTestesFHD").GetComponent<Image>();
        campoFHD = GameObject.Find("campoFHD").GetComponent<Image>();
        bladeFHD = GameObject.Find("bladeFHD").GetComponent<Image>();
        cybercityFHD = GameObject.Find("cybercityFHD").GetComponent<Image>();

        apJonesLightOnFHD = GameObject.Find("apJonesLightOnFHD").GetComponent<Image>();
        apJonesLightOffFHD = GameObject.Find("apJonesLightOffFHD").GetComponent<Image>();
        diarioFHD = GameObject.Find("diarioFHD").GetComponent<Image>();
        estacao13_8FHD = GameObject.Find("estacao13_8FHD").GetComponent<Image>();
        estacao14_7FHD = GameObject.Find("estacao14_7FHD").GetComponent<Image>();

        mapaFHD = GameObject.Find("mapaFHD").GetComponent<Image>();
        predioLifeFHD = GameObject.Find("predioLifeFHD").GetComponent<Image>();
        WTS_backgroundFHD = GameObject.Find("WTS_backgroundFHD").GetComponent<Image>();
        WTS_PasswordFHD = GameObject.Find("WTS_PasswordFHD").GetComponent<Image>();
        WTS_FHD = GameObject.Find("WTS_FHD").GetComponent<Image>();
        creditosFHD = GameObject.Find("creditosFHD").GetComponent<Image>();

        acampamentoNoiteFHD.enabled = false;
        acampamentoDiaFHD.enabled = false;
        acampamentoBarracaFHD.enabled = false;
        distritoTestesFHD.enabled = false;
        campoFHD.enabled = false;
        bladeFHD.enabled = false;
        cybercityFHD.enabled = false;
        apJonesLightOffFHD.enabled = false;
        apJonesLightOnFHD.enabled = false;
        diarioFHD.enabled = false;
        estacao13_8FHD.enabled = false;
        estacao14_7FHD.enabled = false;
        mapaFHD.enabled = false;
        predioLifeFHD.enabled = false;
        WTS_backgroundFHD.enabled = false;
        WTS_PasswordFHD.enabled = false;
        WTS_FHD.enabled = false;
        creditosFHD.enabled = false;


        //desativo todas as artes na tela caso os campos estejam vazios
        if (nomeBackground == "" && setActive == false)
        {
            acampamentoNoiteFHD.enabled = false;
            acampamentoDiaFHD.enabled = false;
            acampamentoBarracaFHD.enabled = false;
            distritoTestesFHD.enabled = false;
            campoFHD.enabled = false;
            bladeFHD.enabled = false;
            cybercityFHD.enabled = false;
            apJonesLightOffFHD.enabled = false;
            apJonesLightOnFHD.enabled = false;
            diarioFHD.enabled = false;
            estacao13_8FHD.enabled = false;
            estacao14_7FHD.enabled = false;
            mapaFHD.enabled = false;
            predioLifeFHD.enabled = false;
            WTS_backgroundFHD.enabled = false;
            WTS_PasswordFHD.enabled = false;
            WTS_FHD.enabled = false;
            creditosFHD.enabled = false;

        }




        //ativo ou desativo as artes na tela.
        if (nomeBackground == "acampamentoNoiteFHD" && setActive == true)
        {
            acampamentoNoiteFHD.enabled = setActive;
        }
        else {
            acampamentoNoiteFHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "acampamentoDiaFHD" && setActive == true)
        {
            acampamentoDiaFHD.enabled = setActive;
        }
        else
        {
            acampamentoDiaFHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "acampamentoBarracaFHD" && setActive == true)
        {
            acampamentoBarracaFHD.enabled = setActive;
        }
        else
        {
            acampamentoBarracaFHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "distritoTestesFHD" && setActive == true)
        {
            distritoTestesFHD.enabled = setActive;
        }
        else
        {
            distritoTestesFHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "campoFHD" && setActive == true)
        {
            campoFHD.enabled = setActive;
        }
        else
        {
            campoFHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "bladeFHD" && setActive == true)
        {
            bladeFHD.enabled = setActive;
        }
        else
        {
            bladeFHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "cybercityFHD" && setActive == true)
        {
            cybercityFHD.enabled = setActive;
        }
        else
        {
            cybercityFHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "apJonesLightOffFHD" && setActive == true)
        {
            apJonesLightOffFHD.enabled = setActive;
        }
        else
        {
            apJonesLightOffFHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "apJonesLightOnFHD" && setActive == true)
        {
            apJonesLightOnFHD.enabled = setActive;
        }
        else
        {
            apJonesLightOnFHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "diarioFHD" && setActive == true)
        {
            diarioFHD.enabled = setActive;
        }
        else
        {
            diarioFHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "estacao13_8FHD" && setActive == true)
        {
            estacao13_8FHD.enabled = setActive;
        }
        else
        {
            estacao13_8FHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "estacao14_7FHD" && setActive == true)
        {
            estacao14_7FHD.enabled = setActive;
        }
        else
        {
            estacao14_7FHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "mapaFHD" && setActive == true)
        {
            mapaFHD.enabled = setActive;
        }
        else
        {
            mapaFHD.enabled = false;

        }

        //ativo ou desativo as artes na tela.
        if (nomeBackground == "predioLifeFHD" && setActive == true)
        {
            predioLifeFHD.enabled = setActive;
        }
        else
        {
            predioLifeFHD.enabled = false;

        }

        if (nomeBackground == "WTS_backgroundFHD" && setActive == true)
        {
            WTS_backgroundFHD.enabled = setActive;
        }
        else
        {
            WTS_backgroundFHD.enabled = false;

        }
        if (nomeBackground == "WTS_PasswordFHD" && setActive == true)
        {
            WTS_PasswordFHD.enabled = setActive;
        }
        else
        {
            WTS_PasswordFHD.enabled = false;

        }

        if (nomeBackground == "WTS_FHD" && setActive == true)
        {
            WTS_FHD.enabled = setActive;
        }
        else
        {
            WTS_FHD.enabled = false;

        }

        if (nomeBackground == "creditosFHD" && setActive == true)
        {
            creditosFHD.enabled = setActive;
        }
        else
        {
            creditosFHD.enabled = false;

        }

        if (nomeBackground == "predioLifeFHD" && setActive == true)
        {
            predioLifeFHD.enabled = setActive;
        }
        else
        {
            predioLifeFHD.enabled = false;

        }

        


    }


}
