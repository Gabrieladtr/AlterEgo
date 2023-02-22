using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveProgressClass : MonoBehaviour
{

//Essa classe serve para salvar, carregar e deletar saves do jogador.


public static bool snBool = false;
public static string slotSaveGame;
public static TMP_Text saving1TMP, saving2TMP, saving3TMP, snTMP, loadTMP;



//-------------------------------------Sistema de save ------------------------------------


    public void SimFoiPressionado(bool chave)
    {
        //Essa chave faz com que trave o salvamento, permitindo salvar apenas uma vez por "etapa"
        //So vai salvar se o snbool for igual a true, caso nao ele nao permite o salvamento.
        snBool = chave;
        Debug.Log("Estamos em 'SimFoiPressionado' e o valor de 'snBool' eh: " + snBool);
    }

    public void DefineSlot(string slotEscolhido) 
    {
        //vai definir em qual slot estamos salvando o jogo.
        //O jogador vai escolher o botao do slot e depois deve salvar automaticamente.
        slotSaveGame = slotEscolhido;
        Debug.Log("Slot para salvamento escolhido. Slot: " + slotEscolhido);
        
    }

    public void SaveGame(string slot) 
    {
        //esse metodo sera capaz de entender em qual fase estamos e deve salvar o jogo de acordo com a fase/slot escolhido.

        SimFoiPressionado(true);
        //vai destravar para salvar, com o snBool com true.
        DefineSlot(slot);
        //Vai definir em qual o slot de salvamento vai salvar o game.

        Debug.Log("estamos em 'SaveGame' e a 'escolhaDialogica' eh: " + Game.faseAtual2 +" 'vazio' " + ". Nenhuma informacao foi salva ainda. A fase atual eh: " + Game.faseAtual2);


        //salva o jogo automaticamente, se alguma frase listada aparecer nesse switch. Pois chama o @Save1Progress().
            switch (Game.faseAtual2)
            {
                case "frasesUm":
                Debug.Log("Estamos em SaveGame/FrasesUm/Switch. 'slotSaveGame': " + slotSaveGame + " 'faseAtual2': "+ Game.faseAtual2 + ". SimFoiPressionado: " + snBool);

                    if (snBool == true)
                    {
                        Save1Progress(slotSaveGame, Game.faseAtual2);
                        
                }
                else { Debug.Log("Estamos em 'SaveGame/frasesUm'. O slot para salvar nao foi encontrado ou o snbool nao eh true. Estamos na 'EscolhaDialogica': " + Game.faseAtual2); }
                    
                break;

                case "frasesDois":
                Debug.Log("Estamos em SaveGame/FrasesUm/Switch. 'slotSaveGame': " + slotSaveGame + " 'faseAtual2': "+ Game.faseAtual2 + ". SimFoiPressionado: " + snBool);

                    if (slotSaveGame != null && snBool == true)
                    {
                        Save1Progress(slotSaveGame, Game.faseAtual2);
                        //SimFoiPressionado(false);
                }
                else { Debug.Log("Estamos em 'SaveGame/frasesDois'. O slot para salvar nao foi encontrado ou o snbool nao eh true. Estamos na 'EscolhaDialogica': " + Game.faseAtual2); }

                break;

                default:
                    Debug.Log("Estamos em 'SaveGame()' e nenhum save foi salvo. Escolha dialogica: " + Game.faseAtual2);
                    break;

            }
        


    }


    public void TesteValor()
    {

        saving1TMP = GameObject.Find("TMPteste").GetComponent<TMP_Text>();
        saving1TMP.text = "Save 1: Teste";
        Debug.Log("Save 1: Teste");

    }

    public void Save1Progress(string slot, string listaAtual)
    {
        
        //vai salvar o progresso do jogo e desativar a chave 'snBool', permitindo salvar em algum outro momento.

        //Vamos usar o 'slot' para o lugar de salvamento
        //Vamos usar o 'listaAtual' para salvar no slot.

        PlayerPrefs.SetString(slot, listaAtual);
        //for@a o salvamento
        PlayerPrefs.Save();
     
       
        //se estivermos dentro da tela de game, vai fazer isso.
        saving1TMP = GameObject.Find("SalvarProgressoGameTMP").GetComponent<TMP_Text>();
        saving1TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
        Debug.Log("Dados salvos no slot: " + slot+". Nome da lista salva: " + listaAtual);

        
        //se estivermos dentro da tela de saving, vai mostrar os dados salvos dentro do botao salvo.
        saving1TMP = GameObject.Find("TMPteste").GetComponent<TMP_Text>();
        saving1TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
        
        

        //preciso criar um controle de qual botao foi pressionado para ai sim mandar a msg no tmp dos botoes
        //se slotSaveGame for igual Espaco1, entao TMP == mostre a msg nesse botao.

        if(slotSaveGame == "Espaco1")
        {
            saving2TMP = GameObject.Find("SavingUm_TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
            Debug.Log("Dados salvos no slot: " + slot+". Nome da lista salva: " + listaAtual);

        }
        else if(slotSaveGame == "Espaco2")
        {
            saving2TMP = GameObject.Find("Saving2TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
            Debug.Log("Dados salvos no slot: " + slot+". Nome da lista salva: " + listaAtual);

        }
        else if(slotSaveGame == "Espaco3")
        {
            saving2TMP = GameObject.Find("Saving3TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
            Debug.Log("Dados salvos no slot: " + slot+". Nome da lista salva: " + listaAtual);

        }
        

        

        SimFoiPressionado(false);
    }

    //---------------------------------------------Sistema de Loading--------------------------------------------

    public void LoadSave1()
    {
        //vai carregar o progresso do 1@ save do jogador
        //Esse metodo deve ser usado na tela de loading.

        

        //dados da tela de loading
        loadTMP = GameObject.Find("SaveLoading1_TMP").GetComponent<TMP_Text>();
        loadTMP.text = "Load 1: " + PlayerPrefs.GetString("testeSlot", "Nenhum save encontrado") + ". Slot: " + "testeSlot";


    }

    public void LoadSave2()
    {
        //vai carregar o progresso do 1@ save do jogador
        //Esse metodo vai ser usado na tela de 'Game', para testes.

        //dados da tela de game
        saving1TMP = GameObject.Find("SalvarProgressoGameTMP").GetComponent<TMP_Text>();
        saving1TMP.text = "Load 1: " + PlayerPrefs.GetString(slotSaveGame, "Nenhum save encontrado") + ". Slot: " + slotSaveGame;


    }

    //---------------------------------------------Delete de Saves--------------------------------------------

    public void ApagarSaves() 
    {
        //na teoria, apaga todos os saves
        PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey(slotSaveGame);
        PlayerPrefs.DeleteKey("save_1");
        PlayerPrefs.DeleteKey("save_2");
        saving1TMP = GameObject.Find("SalvarProgressoGameTMP").GetComponent<TMP_Text>();
        saving1TMP.text = "Delete 1: " + PlayerPrefs.GetString("save_2", "Dados apagados");
        Debug.Log("Saves apagados");
    }
    
    public void ApagarSavesPorSlot(string slot) 
    {
        //na teoria, apaga o save escolhido.
        //Deve ser inicializado dentro de MenuSaving.

        PlayerPrefs.DeleteKey(slot);

        if(slot == "Espaco1")
        {
            saving2TMP = GameObject.Find("SavingUm_TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
            Debug.Log("Save apagado do slot 1");
        }
        else if(slot == "Espaco2")
        {
            saving2TMP = GameObject.Find("Saving2TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
            Debug.Log("Save apagado do slot 2");
        }
        else if(slot == "Espaco3")
        {
            saving2TMP = GameObject.Find("Saving3TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
            Debug.Log("Save apagado do slot 3");
        }

        
    }







}
