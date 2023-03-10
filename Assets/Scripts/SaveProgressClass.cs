//using System.Reflection.PortableExecutable;
//using System.Diagnostics;
using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Globalization;


public class SaveProgressClass : MonoBehaviour
{

//Essa classe serve para salvar, carregar e deletar saves do jogador.


public static bool snBool = false;
public static string slotSaveGame;
public static TMP_Text saving1TMP, saving2TMP, saving3TMP, snTMP, loadTMP;
public static DateTime horaDataAtual;

//O resto da hora deve ser armazenado aqui e nao em um DateTime.
public static TimeSpan restoData1;
public static TimeSpan restoData2;
public static TimeSpan restoData3;

//deve retornar true caso a msg deva ser mostrada para o jogador na tela.
public static bool mostrarMsgNaTelaDesejaSalvar = false;








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
        //vai destravar para salvar, com o 'snBool' com true.
        DefineSlot(slot);
        //Vai definir em qual o slot de salvamento vai salvar o game em 'slotSaveGame'

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
        
        //forca o salvamento
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
            horaDataAtual = DateTime.Now;
            saving2TMP = GameObject.Find("SavingUm_TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado")  + ". Slot: " + slot + ". Data e hora: " + horaDataAtual;
            string horaDataAtualString = horaDataAtual.ToString();
            //vai salvar o horario do primeiro salvamento.

            PlayerPrefs.SetString("DataHora1", horaDataAtualString);
            Debug.Log("Dados salvos no slot: " + slot + ". Nome da lista salva: " + listaAtual + ". Data e hora: " + horaDataAtual);

        }
        else if(slotSaveGame == "Espaco2")
        {
            horaDataAtual = DateTime.Now;
            saving2TMP = GameObject.Find("Saving2TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot + ". Data e hora: " + horaDataAtual;
            string horaDataAtualString = horaDataAtual.ToString();
            //vai salvar o horario do primeiro salvamento.
            PlayerPrefs.SetString("DataHora2", horaDataAtualString);
            Debug.Log("Dados salvos no slot: " + slot + ". Nome da lista salva: " + listaAtual + ". Data e hora: " + horaDataAtual);

        }
        else if(slotSaveGame == "Espaco3")
        {
            horaDataAtual = DateTime.Now;
            saving2TMP = GameObject.Find("Saving3TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot + ". Data e hora: " + horaDataAtual;
            string horaDataAtualString = horaDataAtual.ToString();
            //vai salvar o horario do primeiro salvamento.
            PlayerPrefs.SetString("DataHora3", horaDataAtualString);
            Debug.Log("Dados salvos no slot: " + slot + ". Nome da lista salva: " + listaAtual + ". Data e hora: " + horaDataAtual);

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

    


    
    public static void VerificaUltimoSave()
    {
        //Verifica se existe algum save novo criado nos ultimos minutos.
        //Se sim, deve retornar true na variavel 'mostrarMsgNaTelaDesejaSalvar'.
        
        //pego a dataHora atual pra comparar
        horaDataAtual = DateTime.Now;


        //Pego a dataHoras salvas nos slots de salvamentos.
        //Se nao houver nenhuma informacao salva, caso seja o primeiro gameplay do jogador
        //ou ele tenha decidido apagar todos os saves,coloquei um save "padrao" para nao atrapalhar os calculos
        //de data e hora.
        string dataStringSalva1 = PlayerPrefs.GetString("DataHora1","01/01/2000 12:05:05");
        string dataStringSalva2 = PlayerPrefs.GetString("DataHora2","01/01/2000 12:05:05");
        string dataStringSalva3 = PlayerPrefs.GetString("DataHora3","01/01/2000 12:05:05");

        //Imprimo das datas salvas
        //Debug.Log("A Data1 salva: "+ dataStringSalva1 + ". A Data2 salva: "+ dataStringSalva2 + ". A Data3 salva: "+ dataStringSalva3);
        //Defino o formato usado no horario salvo
        string formatoDataSalva = "dd/MM/yyyy HH:mm:ss";

        //Preciso converter a string no formato brasileiro de data para o formato padrao do DateTime,
        // para internamente ele converter de novo para podermos usa-lo nas comparacoes.
        //O DateTime.Parse apenas nao funciona, preciso repassar toda a formatacao usada.
        DateTime horaDataAtualLoading1 = DateTime.ParseExact(dataStringSalva1, formatoDataSalva, CultureInfo.InvariantCulture);
        DateTime horaDataAtualLoading2 = DateTime.ParseExact(dataStringSalva2, formatoDataSalva, CultureInfo.InvariantCulture);
        DateTime horaDataAtualLoading3 = DateTime.ParseExact(dataStringSalva3, formatoDataSalva, CultureInfo.InvariantCulture);
        
        

        
        //vamos verificar se a hora atual eh maior ou menor que o tempo salvo em algum save do jogador.
        //Se a hora atual for maior do que 3 minutos de algum save, uma mensagem aparecerá quando o jogador quiser sair do jogo ou voltar ao menu principal.
        //Informando que talvez ele nao tenha salvo o jogo dele e que pode perder o progresso. 

        //---------------verifica os dados de tempo do save 1------------------------
        if (horaDataAtual < horaDataAtualLoading1)
        {
            
            Debug.Log("A Data atual: "+ horaDataAtual +" é antes da Data do save 1: " + horaDataAtualLoading1);

        }
        else if (horaDataAtual > horaDataAtualLoading1)
        {
            
            Debug.Log("A Data atual: "+ horaDataAtual +" é depois da Data salva no save 1: " + horaDataAtualLoading1);
            restoData1 = horaDataAtual.Subtract(horaDataAtualLoading1);
            //converte o TimeSpan para string, podendo imprimir na tela com o formato certo
            string tempoRestoData = restoData1.ToString(@"hh\:mm");
            Debug.Log("O slot 1 foi o seu ultimo jogo  salvo com seu progresso em: "+ tempoRestoData + " horas/minutos...");
        }
        else
        {
            Debug.Log("horaDataAtual eh igual a horaDataAtualLoading1");
        }

        //---------------verifica os dados de tempo do save 2------------------------
        if (horaDataAtual < horaDataAtualLoading2)
        {
            
            Debug.Log("A Data atual: "+ horaDataAtual +" é antes da Data do save 2: " + horaDataAtualLoading2);

        }
        else if (horaDataAtual > horaDataAtualLoading2)
        {
            
            Debug.Log("A Data atual: "+ horaDataAtual +" é depois da Data salva no save 2: " + horaDataAtualLoading2);
            restoData2 = horaDataAtual.Subtract(horaDataAtualLoading2);
            //converte o TimeSpan para string, podendo imprimir na tela com o formato certo
            string tempoRestoData = restoData2.ToString(@"hh\:mm");
            Debug.Log("O slot 2 foi o seu ultimo jogo  salvo com seu progresso em: "+tempoRestoData + " horas/minutos...");
        }
        else
        {
            Debug.Log("horaDataAtual é igual a horaDataAtualLoading2");
        }

        //---------------verifica os dados de tempo do save 3------------------------
        if (horaDataAtual < horaDataAtualLoading3)
        {
            
            Debug.Log("A Data atual: "+ horaDataAtual +" eh antes da Data do save 3: " + horaDataAtualLoading3);

        }
        else if (horaDataAtual > horaDataAtualLoading3)
        {
            
            Debug.Log("A Data atual: "+ horaDataAtual +" eh depois da Data salva no save 3: " + horaDataAtualLoading3);
            restoData3 = horaDataAtual.Subtract(horaDataAtualLoading3);
            //converte o TimeSpan para string, podendo imprimir na tela com o formato certo
            string tempoRestoData = restoData3.ToString(@"hh\:mm");
            Debug.Log("O slot 3 foi o seu ultimo jogo salvo com seu progresso em: "+tempoRestoData + " horas/minutos...");
        }
        else
        {
            Debug.Log("horaDataAtual eh igual a horaDataAtualLoading3");
        }



        //---------------Verifico se algum dos restos de tempo eh menor do que 3 minutos---------------
        
        //repasso o tempo de 3 minutos para 'tempoNecessarioParaMsg', usaremos para comparar.
        TimeSpan tempoNecessarioParaMsg = new TimeSpan(0,3,0);


        if(restoData1 < tempoNecessarioParaMsg || restoData2 < tempoNecessarioParaMsg || restoData3 <  tempoNecessarioParaMsg )
        {
            mostrarMsgNaTelaDesejaSalvar = false;
            Debug.Log("Nao deve mostrar a msg. Algum dos saves foi salvo recentemente. 'mostrarMsgNaTelaDesejaSalvar': " + mostrarMsgNaTelaDesejaSalvar);
            

        }else if (restoData1 > tempoNecessarioParaMsg || restoData2 > tempoNecessarioParaMsg || restoData3 >  tempoNecessarioParaMsg ){
            mostrarMsgNaTelaDesejaSalvar = true;
            Debug.Log("Voce nao salvou o jogo nos ultimos 3 minutos. Deseja salvar? 'mostrarMsgNaTelaDesejaSalvar': " + mostrarMsgNaTelaDesejaSalvar);
            
        }else{
            //se o if pegar qualquer situacao a parte do que descrevi, nao deve mostrar msg nenhuma para o player
            //mostrarMsgNaTelaDesejaSalvar = false;
        }

        


        
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

        //atualiza na tela se foi ou nao apagado.
        if(slot == "Espaco1")
        {
            PlayerPrefs.DeleteKey("DataHora1");//apaga a hora do save
            saving2TMP = GameObject.Find("SavingUm_TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
            Debug.Log("Save apagado do slot 1");
        }
        else if(slot == "Espaco2")
        {
            PlayerPrefs.DeleteKey("DataHora2");//apaga a hora do save
            saving2TMP = GameObject.Find("Saving2TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
            Debug.Log("Save apagado do slot 2");
        }
        else if(slot == "Espaco3")
        {
            PlayerPrefs.DeleteKey("DataHora3");//apaga a hora do save
            saving2TMP = GameObject.Find("Saving3TMP").GetComponent<TMP_Text>();
            saving2TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
            Debug.Log("Save apagado do slot 3");
        }

        
    }







}
