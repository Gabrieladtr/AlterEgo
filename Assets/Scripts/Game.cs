using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Game : MonoBehaviour
{

    /*Nesse script vamos trabalhar em:
     * -escolha de di@logo
     * -escolha de decis@es
     * -sistema de save
     * -sistema de loading
    
    O sistema de gameplay @ relativamente simples.*/


    //Todas as minhas variaveis globais para os metodos:

    //Define as listas que ser@o usadas para armazenar as frases
    public List<string> frasesPadrao;
    public List<string> frasesUm;
    public List<string> frasesDois;
    public List<string> frasesTres;

    public ListasDialogicas listasDialogicasObject, listasDialogicasObject2;

    //Rotas possiveis:
    public string rota1, rota2, rota3;


    //define os bot@es que ser@o usados para fazermos escolhas
    public static Button escolhaN1, escolhaN2, escolhaN3, voltarPause;

    //define os TMP dos bot@es que ser@o usados para fazermos escolhas
    public static TMP_Text escolhaNUMtmp, escolhaNDOIStmp, escolhaNTREStmp;
    public static TMP_Text textMeshProTela;

    //contador;
    public int contador = 0;
    public static int contadorDeAcoes;

    //vai definir a escolha de rota que devemos inicializar/em que estamos atualmente (qual lista de frase devemos iniciar)
    public string escolhaDialogica = "Sem valor definido";
    public static string faseAtual2;
    public static string faseAtual3LoadGame;

    //bool pra travar de iniciar pela msm lista de frases:
    public static bool escolhaDialogicaBool = true;
    //serve pra verificar em qual dentro do metodo 'DecisaoDialogicaList' em qual lista estamos
    public static List<string> escolhaDialogicaList;
    //serve pra ver qual botao foi pressionado
    public string algumBotaoFoiPressionado;
    //serve pra ver se os botoes estao na tela
    public bool osBotoesEstaoAtivosNaTela;
    //Nao estou usando, mas serviria pra verificar o index do dialogo.
    public int currentDialogueIndex = 0;

    public static bool enableButtonsOnScreen;

    void Start()
    {

        // listas de frases para combinar com as escolhas
        
        frasesPadrao.Add("frasesPadrao - teste de frase 0");
        frasesPadrao.Add("frasesPadrao - teste de frase 1");
        frasesPadrao.Add("frasesPadrao - teste de frase 2");
        frasesPadrao.Add("frasesPadrao - teste de frase 3");
        frasesPadrao.Add("frasesPadrao - teste de frase 4");
        frasesPadrao.Add("frasesPadrao - teste de frase 5");
        frasesPadrao.Add("frasesPadrao - teste de frase 6");
        frasesPadrao.Add("frasesPadrao - teste de frase 7");
        frasesPadrao.Add("frasesPadrao - teste de frase 8");
        frasesPadrao.Add("frasesPadrao - teste de frase 9");
        frasesPadrao.Add("frasesPadrao - teste de frase 10");
        

        frasesUm.Add("D1E1 - teste de frase 0");
        frasesUm.Add("D1E1 - teste de frase 1");
        frasesUm.Add("D1E1 - teste de frase 2");
        frasesUm.Add("D1E1 - teste de frase 3");
        frasesUm.Add("D1E1 - teste de frase 4");
        frasesUm.Add("D1E1 - teste de frase 5");
        frasesUm.Add("D1E1 - teste de frase 6");
        frasesUm.Add("D1E1 - teste de frase 7");
        frasesUm.Add("D1E1 - teste de frase 8");
        frasesUm.Add("D1E1 - teste de frase 9");
    
        frasesDois.Add("D1E2 - teste de frase 0");
        frasesDois.Add("D1E2 - teste de frase 1");
        frasesDois.Add("D1E2 - teste de frase 2");
        frasesDois.Add("D1E2 - teste de frase 3");
        frasesDois.Add("D1E2 - teste de frase 4");
        frasesDois.Add("D1E2 - teste de frase 5");
        frasesDois.Add("D1E2 - teste de frase 6");
        frasesDois.Add("D1E2 - teste de frase 7");
        frasesDois.Add("D1E2 - teste de frase 8");
        frasesDois.Add("D1E2 - teste de frase 9");

        frasesTres.Add("D1E3 - teste de frase 0");
        frasesTres.Add("D1E3 - teste de frase 1");
        frasesTres.Add("D1E3 - teste de frase 2");
        frasesTres.Add("D1E3 - teste de frase 3");
        frasesTres.Add("D1E3 - teste de frase 4");
        frasesTres.Add("D1E3 - teste de frase 5");
        frasesTres.Add("D1E3 - teste de frase 6");
        frasesTres.Add("D1E3 - teste de frase 7");
        frasesTres.Add("D1E3 - teste de frase 8");
        frasesTres.Add("D1E3 - teste de frase 9");
        frasesTres.Add("D1E3 - teste de frase 10");
        frasesTres.Add("D1E3 - teste de frase 11");
        frasesTres.Add("D1E3 - teste de frase 12");
        frasesTres.Add("D1E3 - teste de frase 13");
        frasesTres.Add("D1E3 - teste de frase 14");
        frasesTres.Add("D1E3 - teste de frase 15");
        
        frasesTres.Add("D1E3 - teste de frase 16");
        frasesTres.Add("D1E3 - teste de frase 17");
        frasesTres.Add("D1E3 - teste de frase 18");
        frasesTres.Add("D1E3 - teste de frase 19");
        frasesTres.Add("D1E3 - teste de frase 20");
        frasesTres.Add("D1E3 - teste de frase 21");
        frasesTres.Add("D1E3 - teste de frase 22");
        frasesTres.Add("D1E3 - teste de frase 23");
        frasesTres.Add("D1E3 - teste de frase 24");
        frasesTres.Add("D1E3 - teste de frase 25");
        frasesTres.Add("D1E3 - teste de frase 26");
        frasesTres.Add("D1E3 - teste de frase 27");
        frasesTres.Add("D1E3 - teste de frase 28");
        frasesTres.Add("D1E3 - teste de frase 29");
        frasesTres.Add("D1E3 - teste de frase 30");
        






        // Esconder os bot@es de escolha inicialmente

        //Aqui eu instancio e encontro os botoes dentro da cena

        //Verifico se os botoes estao em cena primeiramente
        if (GameObject.Find("Botao_escolha1") == true && GameObject.Find("Botao_escolha2") == true && GameObject.Find("Botao_escolha3") == true
            ) 
        {
            escolhaN1 = GameObject.Find("Botao_escolha1").GetComponent<Button>();
            escolhaN2 = GameObject.Find("Botao_escolha2").GetComponent<Button>();
            escolhaN3 = GameObject.Find("Botao_escolha3").GetComponent<Button>();

            //Aqui eu instancio e encontro os TMP dos botoes dentro da cena
            escolhaNUMtmp = GameObject.Find("Botao_escolha1TMP").GetComponent<TMP_Text>();
            escolhaNDOIStmp = GameObject.Find("Botao_escolha2TMP").GetComponent<TMP_Text>();
            escolhaNTREStmp = GameObject.Find("Botao_escolha3TMP").GetComponent<TMP_Text>();

            //Inicialmente os botoes nao aparecem na cena
            ButtonsOnScreen(false);
            
        }



        //Vamos inputar o "frasesPadrao" como padrao para come@ar a calcular as frases e as rotas possiveis. 
        //Ou seja, vamos come@ar o jogo com essa lista de frases.
        //Se o meu 'escolhaDialogicaBool == true', entao deve inputar o um 'DecisaoDialogica("frasesPadrao")'
        //Caso contr�rio, nao faz nada.

        if (escolhaDialogicaBool == true)
        {
            //vai add o valor 'frasesPadrao' em 'escolhaDialogica'
            DecisaoDialogica("prologo");
            
            //vai travar, nao permitindo que nada mais seja add em 'escolhaDialogica', funcionando apenas 1 vez.
            escolhaDialogicaBool = false;

            Debug.Log("Estamos dentro do primeiro IF, onde escolhemos o 'prologo', Game.escolhaDialogicaBool: " + escolhaDialogicaBool);
        }
        else if(escolhaDialogicaBool == false) 
        {
            //Debug.Log("Nao tem nenhuma lista padrao. A variavel bool 'escolhaDialogicaBool' esta: " + escolhaDialogicaBool +  "." + " A EscolhaDialogica eh: " + escolhaDialogica);
            //escolhaDialogicaBool = true;
        }


        //PauseGame.pauseActive = false;//vamos dizer para o sistema de pause que ele sempre podera ser ativo, toda vez que essa cena for ativada.


        



    }






    void Update()
    {
        //-----------------------Criando o objeto das ListasDialogicas-------------------------
        listasDialogicasObject = new ListasDialogicas();






        //ListasDialogicas listasDialogicasClasse = new ListasDialogicas();

        //Pega o componente de texto na tela e mostra a frase que eu atribuir dentro do TMP

        if (GameObject.Find("Dialogo") == true) 
        {
            textMeshProTela = GameObject.Find("Dialogo").GetComponent<TMP_Text>();
        }

        //vai pegar a cena atual
        Scene GameScene = SceneManager.GetActiveScene();
        

        //Rota acrescentando dialogo com o botao esquerdo do mouse
        if (Input.GetMouseButtonDown(0) && GameScene.name == "Game")
        {

            
            


            //Esse sistema vai impedir o jogador de ultrapassar/retroceder o numero de frases dentro de uma lista
            //E vai come@ar a contar cada frase, permitindo a exibi@@o na tela

            if (contador > DecisaoDialogicaList(escolhaDialogica).Count)
            {
                //verifica se o contador eh maior que o numero de frases dentro da lista de frases
                //Se o contador for maior, entao deve parar de contar. Se for menor de 0 deve parar de contar tmb.    
                //Isso significa que o jogador nao vai poder avan@ar ou retroceder o dialogo se nao tiver mais dialogo algum.

                //isso deve parar de acrescentar valores ao clicar com o botao do mouse esquerdo
                contador = DecisaoDialogicaList(escolhaDialogica).Count;
                //Debug.Log("Estamos parados na ultima frase da lista (Input.GetMouseButtonDown(0)) e nao podemos avancar mais dialogos. O contador atual eh: " + contador);
                
                
            }
            else 
            {
                //caso contr@rio s@ acrescente valores no contador.
                contador++;
                //Debug.Log("Numero de cliques: " + contador);
                //Debug.Log("Contador atual: " + contador);
                //contador = contador + 1 == acrescenta valores
                //contador = contador - 1== diminui valores
                //contador = DecisaoDialogicaList(escolhaDialogica).Count == trava o contador na contagem final da frase.

            }










            //Esse @ o sistema de escolha de dialogo.


            //------------------------------------------Estamos acrescentando dialogo------------------------------------------

            switch (escolhaDialogica)
            {
                case "prologo":

                    if (contador < listasDialogicasObject.GetPrologo().Count && contador != listasDialogicasObject.GetPrologo().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetPrologo()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetPrologo()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetPrologo().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);


                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_1", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_1", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }
                    break;

                case "Capitulo_1":

                    if (contador < listasDialogicasObject.GetCapitulo_1().Count && contador != listasDialogicasObject.GetCapitulo_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    } else if (contador == listasDialogicasObject.GetCapitulo_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_1_1", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_1_1", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    } 
                    break;

                case "Capitulo_1_1":

                    if (contador < listasDialogicasObject.GetCapitulo_1_1().Count && contador != listasDialogicasObject.GetCapitulo_1_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    } else if (contador == listasDialogicasObject.GetCapitulo_1_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_1_2", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_1_2", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    } 
                    break;

                case "Capitulo_1_2":

                    if (contador < listasDialogicasObject.GetCapitulo_1_2().Count && contador != listasDialogicasObject.GetCapitulo_1_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    } else if (contador == listasDialogicasObject.GetCapitulo_1_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Fazer parte dos Animals, com o Alter Ego “Cão”", "Não fazer parte dos Animals, decidir apenas seguir seu caminho em busca dos cacos de vidro que um dia foram a vidraça de sua vida. Lutar contra os fantasmas do passado e lidar com o mundo caótico que se vive. Viver com o peso nas suas costas que é saber, que você deixou de lado salvar a humanidade por querer descobrir quem é você e qual é seu papel nesse mundo, sozinho.", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        //Ordem dos botoes: botao1, botao2, botao3
                        Rotas("Capitulo_1_3_1", "Capitulo_1_3_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        
                    }
                    break;



                case "Capitulo_1_3_1":

                    //Final 1
                    // Acoes a serem executadas quando a opcao 1 eh selecionada
                    if (contador < listasDialogicasObject.GetCapitulo_1_3_1().Count && contador != listasDialogicasObject.GetCapitulo_1_3_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1_3_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1_3_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_1_3_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_1_4", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_1_4", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_1_3_2":

                    //Final 1
                    // Acoes a serem executadas quando a opcao 1 eh selecionada
                    if (contador < listasDialogicasObject.GetCapitulo_1_3_2().Count && contador != listasDialogicasObject.GetCapitulo_1_3_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1_3_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1_3_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_1_3_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo 5: Creditos", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_1_4":

                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < listasDialogicasObject.GetCapitulo_1_4().Count && contador != listasDialogicasObject.GetCapitulo_1_4().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1_4()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1_4()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_1_4().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_2", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_2", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2":

                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < listasDialogicasObject.GetCapitulo_2().Count && contador != listasDialogicasObject.GetCapitulo_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_2_1", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_2_1", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_1":
                    //Vai fazer o puzzle dos drones ou nao?

                    if (contador < listasDialogicasObject.GetCapitulo_2_1().Count && contador != listasDialogicasObject.GetCapitulo_2_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Hackear os drones e conectá-los ao SOV (mais segurança no SOV) = puzzle", "Não hackear os drones e não conectá-los ao SOV (menos segurança no SOV)", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_2_2", "Capitulo_2_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_2":
                    //Puzzle dos drones

                    if (contador < listasDialogicasObject.GetCapitulo_2_2().Count && contador != listasDialogicasObject.GetCapitulo_2_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);
                        //ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("4488", "8844", "4874");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis: (a primeira eh a certa e a segunda e a terceira as erradas.)
                        Rotas("Capitulo_2_3_1", "Capitulo_2_3_2", "Capitulo_2_3_2");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_3_1":
                    //Puzzle dos drones

                    if (contador < listasDialogicasObject.GetCapitulo_2_3_1().Count && contador != listasDialogicasObject.GetCapitulo_2_3_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_3_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_3_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_3_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);
                        //ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Ler o diário de Asimovitsky (trecho grande, cerca de 5 páginas de conteúdo)", "Não ler o diário de Asimovitsky (você pode precisar de alguma informação útil do livro...)", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis: (a primeira eh a certa e a segunda e a terceira as erradas.)
                        Rotas("Capitulo_2_4_1", "Capitulo_3", "Capitulo_2_3_2");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_3_3":
                    //Pulou o Puzzle dos drones

                    if (contador < listasDialogicasObject.GetCapitulo_2_3_3().Count && contador != listasDialogicasObject.GetCapitulo_2_3_3().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_3_3()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_3_3()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_3_3().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Ler o diário de Asimovitsky (trecho grande, cerca de 5 páginas de conteúdo)", "Não ler o diário de Asimovitsky (você pode precisar de alguma informação útil do livro...)", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_2_4_1_v3", "Capitulo_2_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_3_2":
                    //Pulou o Puzzle dos drones

                    if (contador < listasDialogicasObject.GetCapitulo_2_3_2().Count && contador != listasDialogicasObject.GetCapitulo_2_3_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_3_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_3_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_3_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Ler o diário de Asimovitsky (trecho grande, cerca de 5 páginas de conteúdo)", "Não ler o diário de Asimovitsky (você pode precisar de alguma informação útil do livro...)", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis: (a primeira eh a certa e a segunda e a terceira as erradas.)
                        Rotas("Capitulo_2_4_1_v2", "Capitulo_3_2", "Capitulo_2_3_2");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_4":
                    //Pergunta se deseja ler o livro ou não.

                    if (contador < listasDialogicasObject.GetCapitulo_2_4().Count && contador != listasDialogicasObject.GetCapitulo_2_4().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_4()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_4()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_4().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Ler o diário de Asimovitsky (trecho grande, cerca de 5 páginas de conteúdo)",  "Não ler o diário de Asimovitsky (você pode precisar de alguma informação útil do livro...)", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_2_4_1", "Capitulo_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_4_1":
                    //Livro de Asimovitsky

                    if (contador < listasDialogicasObject.GetCapitulo_2_4_1().Count && contador != listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_4_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_4_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_3", "", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_3", "Capitulo_2_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_4_1_v2":
                    //Livro de Asimovitsky

                    if (contador < listasDialogicasObject.GetCapitulo_2_4_1().Count && contador != listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_4_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_4_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_3_2", "", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_3_2", "Capitulo_2_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_4_1_v3":
                    //Livro de Asimovitsky

                    if (contador < listasDialogicasObject.GetCapitulo_2_4_1().Count && contador != listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_4_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_4_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_3_2", "", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_3_3", "Capitulo_2_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_3":
                    

                    if (contador < listasDialogicasObject.GetCapitulo_3().Count && contador != listasDialogicasObject.GetCapitulo_3().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_3()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_3()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_3().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Usar o Código: 7898", "Usar o Código: 7562", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_3_1_1", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_3_2":

                    //Final 5

                    if (contador < listasDialogicasObject.GetCapitulo_3_2().Count && contador != listasDialogicasObject.GetCapitulo_3_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_3_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_3_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_3_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);
                        //ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_4_D", "Capitulo_4_E");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_3_3":


                    if (contador < listasDialogicasObject.GetCapitulo_3_3().Count && contador != listasDialogicasObject.GetCapitulo_3_3().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_3_3()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_3_3()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_3_3 ().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);
                        //ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Escolha C: Usar o Código: 7594", "Escolha D: Usar o Código: 7491", "Escolha E: Usar o Código: 5897");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_4_C", "Capitulo_4_D", "Capitulo_4_E");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_3_1_1":


                    if (contador < listasDialogicasObject.GetCapitulo_3_1_1().Count && contador != listasDialogicasObject.GetCapitulo_3_1_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_3_1_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_3_1_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_3_1_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_4_A", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_4_A", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_4_A":


                    if (contador < listasDialogicasObject.GetCapitulo_4_A().Count && contador != listasDialogicasObject.GetCapitulo_4_A().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_4_A()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_4_A()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_4_A().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_3_1_2":


                    if (contador < listasDialogicasObject.GetCapitulo_3_1_2().Count && contador != listasDialogicasObject.GetCapitulo_3_1_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_3_1_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_3_1_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_3_1_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_4_B", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_4_B", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_4_B":


                    if (contador < listasDialogicasObject.GetCapitulo_4_B().Count && contador != listasDialogicasObject.GetCapitulo_4_B().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_4_B()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_4_B()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_4_B().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_4_C":


                    if (contador < listasDialogicasObject.GetCapitulo_4_C().Count && contador != listasDialogicasObject.GetCapitulo_4_C().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_4_C()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_4_C()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_4_C().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_4_D":


                    if (contador < listasDialogicasObject.GetCapitulo_4_D().Count && contador != listasDialogicasObject.GetCapitulo_4_D().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_4_D()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_4_D()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_4_D().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_4_E":


                    if (contador < listasDialogicasObject.GetCapitulo_4_E().Count && contador != listasDialogicasObject.GetCapitulo_4_E().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_4_E()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_4_E()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_4_E().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_5_Creditos":

                    //Final 1
                    // Acoes a serem executadas quando a opcao 1 eh selecionada
                    if (contador < listasDialogicasObject.GetCapitulo_5_Creditos().Count && contador != listasDialogicasObject.GetCapitulo_5_Creditos().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_5_Creditos()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_5_Creditos()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_5_Creditos().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        //ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo 5: Creditos", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "frasesPadrao":

                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < frasesPadrao.Count && contador != frasesPadrao.Count)
                    {
                        Debug.Log(frasesPadrao[contador]);
                        textMeshProTela.text = frasesPadrao[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);
                        
                    }
                    else if (contador == frasesPadrao.Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_1", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_1", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                    case "frasesDois":
                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < frasesDois.Count && contador != frasesDois.Count)
                    {
                        Debug.Log(frasesDois[contador]);
                        textMeshProTela.text = frasesDois[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == frasesDois.Count)
                    {

                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("frasesPadrao", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("frasesPadrao", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;

                    }
                    break;

                case "frasesTres":
                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < frasesTres.Count && contador != frasesTres.Count)
                    {
                        Debug.Log(frasesTres[contador]);
                        textMeshProTela.text = frasesTres[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == frasesTres.Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("frasesPadrao", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("frasesPadrao", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;

                    }
                    break;

                default:
                    //valor que sera atribuido de forma padrao
                    //Debug.Log("Estamos em 'switch (escolhaDialogica)', onde tomamos decisoes dialogicas. Nenhuma opcao do switch escolhida.");
                    break;


            }


        }

        //------------------------------------------fim da rota acrescentando dialogo------------------------------------------
        //------------------------------------------Comecando a rota decrescendo o dialogo-------------------------------------

        if (Input.GetMouseButtonDown(1) && GameScene.name == "Game")
        {

            
            //escolhaDialogica = "frasesPadrao";

            if (contador <= 0)
            {
                //verifica se o contador @ maior que o numero de frases dentro da lista de frases
                //Se o contador for maior, entao deve parar de contar. Se for menor de 0 deve parar de contar tmb.    
                //Isso significa que o jogador nao vai poder avan@ar ou retroceder o dialogo se nao tiver mais dialogo algum.

                //isso deve parar de acrescentar valores ao clicar com o botao do mouse esquerdo
                contador = 0;
                //Debug.Log("Estamos parados na primeira frase da lista e nao podemos retroceder mais dialogos. O contador atual eh: " + contador);
            }
            else
            {
                //caso contr@rio s@ acrescente valores no contador.
                contador--;
                //Debug.Log("Numero de cliques: " + contador);
                //contador = contador + 1 == acrescenta valores
                //contador = contador - 1== diminui valores
                //contador = DecisaoDialogicaList(escolhaDialogica).Count == trava o contador na contagem final da frase.

            }

//---------------------------------------EscolhaDialogica-------------------------------------
            switch (escolhaDialogica)
            {
                case "prologo":

                    if (contador < listasDialogicasObject.GetPrologo().Count && contador != listasDialogicasObject.GetPrologo().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetPrologo()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetPrologo()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetPrologo().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);


                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_1", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_1", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }
                    break;

                case "Capitulo_1":

                    if (contador < listasDialogicasObject.GetCapitulo_1().Count && contador != listasDialogicasObject.GetCapitulo_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);


                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_1_1", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_1_1", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }
                    break;

                case "Capitulo_1_1":

                    if (contador < listasDialogicasObject.GetCapitulo_1_1().Count && contador != listasDialogicasObject.GetCapitulo_1_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_1_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);


                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_1_2", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_1_2", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }
                    break;

                case "Capitulo_1_2":

                    if (contador < listasDialogicasObject.GetCapitulo_1_2().Count && contador != listasDialogicasObject.GetCapitulo_1_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_1_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Fazer parte dos Animals, com o Alter Ego “Cão”", "Não fazer parte dos Animals, decidir apenas seguir seu caminho em busca dos cacos de vidro que um dia foram a vidraça de sua vida. Lutar contra os fantasmas do passado e lidar com o mundo caótico que se vive. Viver com o peso nas suas costas que é saber, que você deixou de lado salvar a humanidade por querer descobrir quem é você e qual é seu papel nesse mundo, sozinho.", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        //Ordem dos botoes: botao1, botao2, botao3
                        Rotas("Capitulo_1_3_1", "Capitulo_1_3_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.

                    }
                    break;



                case "Capitulo_1_3_1":

                    //Final 1
                    // Acoes a serem executadas quando a opcao 1 eh selecionada
                    if (contador < listasDialogicasObject.GetCapitulo_1_3_1().Count && contador != listasDialogicasObject.GetCapitulo_1_3_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1_3_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1_3_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_1_3_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_1_4", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_1_4", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_1_3_2":

                    //Final 1
                    // Acoes a serem executadas quando a opcao 1 eh selecionada
                    if (contador < listasDialogicasObject.GetCapitulo_1_3_2().Count && contador != listasDialogicasObject.GetCapitulo_1_3_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1_3_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1_3_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_1_3_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo 5: Creditos", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_1_4":

                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < listasDialogicasObject.GetCapitulo_1_4().Count && contador != listasDialogicasObject.GetCapitulo_1_4().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_1_4()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_1_4()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_1_4().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_2", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_2", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2":

                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < listasDialogicasObject.GetCapitulo_2().Count && contador != listasDialogicasObject.GetCapitulo_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_2_1", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_2_1", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_1":
                    //Vai fazer o puzzle dos drones ou nao?

                    if (contador < listasDialogicasObject.GetCapitulo_2_1().Count && contador != listasDialogicasObject.GetCapitulo_2_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Hackear os drones e conectá-los ao SOV (mais segurança no SOV) = puzzle", "Não hackear os drones e não conectá-los ao SOV (menos segurança no SOV)", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_2_2", "Capitulo_2_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_2":
                    //Puzzle dos drones

                    if (contador < listasDialogicasObject.GetCapitulo_2_2().Count && contador != listasDialogicasObject.GetCapitulo_2_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);
                        //ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("4488", "8844", "4874");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis: (a primeira eh a certa e a segunda e a terceira as erradas.)
                        Rotas("Capitulo_2_3_1", "Capitulo_2_3_2", "Capitulo_2_3_2");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_3_1":
                    //Puzzle dos drones

                    if (contador < listasDialogicasObject.GetCapitulo_2_3_1().Count && contador != listasDialogicasObject.GetCapitulo_2_3_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_3_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_3_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_3_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);
                        //ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Ler o diário de Asimovitsky (trecho grande, cerca de 5 páginas de conteúdo)", "Não ler o diário de Asimovitsky (você pode precisar de alguma informação útil do livro...)", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis: (a primeira eh a certa e a segunda e a terceira as erradas.)
                        Rotas("Capitulo_2_4_1", "Capitulo_3", "Capitulo_2_3_2");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_3_3":
                    //Pulou o Puzzle dos drones

                    if (contador < listasDialogicasObject.GetCapitulo_2_3_3().Count && contador != listasDialogicasObject.GetCapitulo_2_3_3().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_3_3()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_3_3()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_3_3().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Ler o diário de Asimovitsky (trecho grande, cerca de 5 páginas de conteúdo)", "Não ler o diário de Asimovitsky (você pode precisar de alguma informação útil do livro...)", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_2_4_1_v3", "Capitulo_2_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_3_2":
                    //Pulou o Puzzle dos drones

                    if (contador < listasDialogicasObject.GetCapitulo_2_3_2().Count && contador != listasDialogicasObject.GetCapitulo_2_3_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_3_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_3_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_3_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Ler o diário de Asimovitsky (trecho grande, cerca de 5 páginas de conteúdo)", "Não ler o diário de Asimovitsky (você pode precisar de alguma informação útil do livro...)", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis: (a primeira eh a certa e a segunda e a terceira as erradas.)
                        Rotas("Capitulo_2_4_1_v2", "Capitulo_3_2", "Capitulo_2_3_2");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_4":
                    //Pergunta se deseja ler o livro ou não.

                    if (contador < listasDialogicasObject.GetCapitulo_2_4().Count && contador != listasDialogicasObject.GetCapitulo_2_4().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_4()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_4()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_4().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Ler o diário de Asimovitsky (trecho grande, cerca de 5 páginas de conteúdo)", "Não ler o diário de Asimovitsky (você pode precisar de alguma informação útil do livro...)", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_2_4_1", "Capitulo_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_4_1":
                    //Livro de Asimovitsky

                    if (contador < listasDialogicasObject.GetCapitulo_2_4_1().Count && contador != listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_4_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_4_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_3", "", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_3", "Capitulo_2_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_4_1_v2":
                    //Livro de Asimovitsky

                    if (contador < listasDialogicasObject.GetCapitulo_2_4_1().Count && contador != listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_4_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_4_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_3_2", "", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_3_2", "Capitulo_2_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_2_4_1_v3":
                    //Livro de Asimovitsky

                    if (contador < listasDialogicasObject.GetCapitulo_2_4_1().Count && contador != listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_2_4_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_2_4_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_2_4_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_3_2", "", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_3_3", "Capitulo_2_3_3", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_3":


                    if (contador < listasDialogicasObject.GetCapitulo_3().Count && contador != listasDialogicasObject.GetCapitulo_3().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_3()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_3()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_3().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Usar o Código: 7898", "Usar o Código: 7562", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_3_1_1", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_3_2":

                    //Final 5

                    if (contador < listasDialogicasObject.GetCapitulo_3_2().Count && contador != listasDialogicasObject.GetCapitulo_3_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_3_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_3_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_3_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);
                        //ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_4_D", "Capitulo_4_E");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_3_3":


                    if (contador < listasDialogicasObject.GetCapitulo_3_3().Count && contador != listasDialogicasObject.GetCapitulo_3_3().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_3_3()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_3_3()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_3_3().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);
                        //ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Escolha C: Usar o Código: 7594", "Escolha D: Usar o Código: 7491", "Escolha E: Usar o Código: 5897");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_4_C", "Capitulo_4_D", "Capitulo_4_E");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_3_1_1":


                    if (contador < listasDialogicasObject.GetCapitulo_3_1_1().Count && contador != listasDialogicasObject.GetCapitulo_3_1_1().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_3_1_1()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_3_1_1()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_3_1_1().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_4_A", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_4_A", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_4_A":


                    if (contador < listasDialogicasObject.GetCapitulo_4_A().Count && contador != listasDialogicasObject.GetCapitulo_4_A().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_4_A()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_4_A()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_4_A().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_3_1_2":


                    if (contador < listasDialogicasObject.GetCapitulo_3_1_2().Count && contador != listasDialogicasObject.GetCapitulo_3_1_2().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_3_1_2()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_3_1_2()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_3_1_2().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_4_B", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_4_B", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_4_B":


                    if (contador < listasDialogicasObject.GetCapitulo_4_B().Count && contador != listasDialogicasObject.GetCapitulo_4_B().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_4_B()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_4_B()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_4_B().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_4_C":


                    if (contador < listasDialogicasObject.GetCapitulo_4_C().Count && contador != listasDialogicasObject.GetCapitulo_4_C().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_4_C()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_4_C()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_4_C().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_4_D":


                    if (contador < listasDialogicasObject.GetCapitulo_4_D().Count && contador != listasDialogicasObject.GetCapitulo_4_D().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_4_D()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_4_D()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_4_D().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_4_E":


                    if (contador < listasDialogicasObject.GetCapitulo_4_E().Count && contador != listasDialogicasObject.GetCapitulo_4_E().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_4_E()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_4_E()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_4_E().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);
                        //ButtonDOIS_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_5_Creditos", "", "");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "Capitulo_3_1_2", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "Capitulo_5_Creditos":

                    //Final 1
                    // Acoes a serem executadas quando a opcao 1 eh selecionada
                    if (contador < listasDialogicasObject.GetCapitulo_5_Creditos().Count && contador != listasDialogicasObject.GetCapitulo_5_Creditos().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetCapitulo_5_Creditos()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetCapitulo_5_Creditos()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetCapitulo_5_Creditos().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        //ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo 5: Creditos", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_5_Creditos", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "frasesPadrao":

                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < frasesPadrao.Count && contador != frasesPadrao.Count)
                    {
                        Debug.Log(frasesPadrao[contador]);
                        textMeshProTela.text = frasesPadrao[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == frasesPadrao.Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        //ButtonsOnScreen(true);
                        ButtonUM_OnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("Capitulo_1", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("Capitulo_1", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "frasesDois":
                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < frasesDois.Count && contador != frasesDois.Count)
                    {
                        Debug.Log(frasesDois[contador]);
                        textMeshProTela.text = frasesDois[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == frasesDois.Count)
                    {

                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("frasesPadrao", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("frasesPadrao", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;

                    }
                    break;

                case "frasesTres":
                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < frasesTres.Count && contador != frasesTres.Count)
                    {
                        Debug.Log(frasesTres[contador]);
                        textMeshProTela.text = frasesTres[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == frasesTres.Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesUm.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("frasesPadrao", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("frasesPadrao", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;

                    }
                    break;

                default:
                    //valor que sera atribuido de forma padrao
                    //Debug.Log("Estamos em 'switch (escolhaDialogica)', onde tomamos decisoes dialogicas. Nenhuma opcao do switch escolhida.");
                    break;


            }

            

        }


        //------------------------------------------Fim do sistema de escolha dialogica------------------------------------------
        
       


    }

    //--------------------------------------Lista de metodos-------------------------------------

    public void ButtonsOnScreen(bool enable)
    {
        if (enable == true) 
        {
            escolhaN1.gameObject.SetActive(true);
            escolhaN2.gameObject.SetActive(true);
            escolhaN3.gameObject.SetActive(true);
        }
        else if (enable == false)
        {
            escolhaN1.gameObject.SetActive(false);
            escolhaN2.gameObject.SetActive(false);
            escolhaN3.gameObject.SetActive(false);
        }
        else if (enable != false && enable != true)
        {
            escolhaN1.gameObject.SetActive(false);
            escolhaN2.gameObject.SetActive(false);
            escolhaN3.gameObject.SetActive(false);
        }






        //Verifica se os botoes estao ativos na tela
        if (enable == true)
        {
            osBotoesEstaoAtivosNaTela = true;
        }
        else 
        {
            osBotoesEstaoAtivosNaTela = false;
        }

        

    }


    public void ButtonUM_OnScreen(bool enable)
    {
        if (enable == true) 
        {
            escolhaN1.gameObject.SetActive(true);
        }
        else if (enable == false)
        {
            escolhaN1.gameObject.SetActive(false);
        }
        else if (enable != false && enable != true)
        {
            escolhaN1.gameObject.SetActive(false);

        }
    }

    public void ButtonDOIS_OnScreen(bool enable)
    {
        if (enable == true) 
        {
            escolhaN2.gameObject.SetActive(true);
        }
        else if (enable == false)
        {
            escolhaN2.gameObject.SetActive(false);
        }
        else if (enable != false && enable != true)
        {
            escolhaN2.gameObject.SetActive(false);

        }
    }

        public void ButtonTRES_OnScreen(bool enable)
    {
        if (enable == true) 
        {
            escolhaN3.gameObject.SetActive(true);
        }
        else if (enable == false)
        {
            escolhaN3.gameObject.SetActive(false);
        }
        else if (enable != false && enable != true)
        {
            escolhaN3.gameObject.SetActive(false);

        }
    }




    //Os proximos 3 metodos verificam se algum dos botoes foi pressionado de forma individual.

    public void Botao1Foipressionado() 
    {
        //Verifica se o botao 1 foi pressionado            
        algumBotaoFoiPressionado = "botao1";
        Debug.Log("botao 1 foi pressionado.");
        Debug.Log("O valor da variavel 'algumBotaoFoiPressionado' eh: " + algumBotaoFoiPressionado);
        VerificaQualBotaoFoiPressinado();
        escolhaN1.gameObject.SetActive(false);
        escolhaN2.gameObject.SetActive(false);
        escolhaN3.gameObject.SetActive(false);
        textMeshProTela.text = "Clique para continuar";
        contador = 0;


    }
    public void Botao2Foipressionado()
    {
        //Verifica se o botao 2 foi pressionado    
        algumBotaoFoiPressionado = "botao2";
        Debug.Log("botao 2 foi pressionado.");
        Debug.Log("O valor da variavel 'algumBotaoFoiPressionado' eh: " + algumBotaoFoiPressionado);
        VerificaQualBotaoFoiPressinado();
        escolhaN1.gameObject.SetActive(false);
        escolhaN2.gameObject.SetActive(false);
        escolhaN3.gameObject.SetActive(false);
        textMeshProTela.text = "Clique para continuar";
        contador = 0;
    }
    public void Botao3Foipressionado()
    {
        //Verifica se o botao 3 foi pressionado    
        algumBotaoFoiPressionado = "botao3";
        Debug.Log("botao 3 foi pressionado.");
        Debug.Log("O valor da variavel 'algumBotaoFoiPressionado' eh: " + algumBotaoFoiPressionado);
        VerificaQualBotaoFoiPressinado();
        escolhaN1.gameObject.SetActive(false);
        escolhaN2.gameObject.SetActive(false);
        escolhaN3.gameObject.SetActive(false);
        textMeshProTela.text = "Clique para continuar";
        contador = 0;
    }


    

    public void ButtonsMessages(string message1, string message2, string message3)
    {
        //esse metodo coloca uma mensagem dentro dos botoes
        escolhaNUMtmp.text = message1;
        escolhaNDOIStmp.text = message2;
        escolhaNTREStmp.text = message3;
        Debug.Log(message1);
        Debug.Log(message2);
        Debug.Log(message3);

    }

    //-------------------------------Escolha Dialogica-------------------------------

    public void DecisaoDialogica(string decisao) {
        //Aqui instanciamos um valor que definir@ para qual rota iremos, ou seja
        //para a variavel global da escolhaDialogica, instanciada globalmente no inicio do codigo.
        //Combinaremos esse metodo com o resultado dos botoes, criando um caminho definido pelo jogador



        //Se 'faseAtual3LoadGame == null', entao significa que nao atribuimos nenhum valor de load, para a 
        //EscolhaDialogica. Entao isso significa uma ordem de prioridade para quem sera carregado com a escolha dialogica.

        if (faseAtual3LoadGame == null)
        {
            escolhaDialogica = decisao;
            faseAtual2 = decisao;
        }
        else {
            escolhaDialogica = faseAtual3LoadGame;
            faseAtual3LoadGame = null;
        }

        Debug.Log("Estamos em 'DecisaoDialogica' e a rota que estamos agora eh: " + escolhaDialogica );



    }



    public List<string> DecisaoDialogicaList(string decisaoList)
    {
        //Vai retornar em qual lista estamos atualmente
        //Serve pra evitar avan@ar ou retroceder demais no di@logo, dependendo da qtd de frases na lista.
        //Deve ter uma inicializacao de cada lista de ListasDialogicas, para podermos acessar os valores.
        listasDialogicasObject2 = new ListasDialogicas();
        
        switch (decisaoList) 
        {
            /*

            //Todas as listas:
    public List<string> prologo;
    public List<string> Capitulo_1, Capitulo_1_1, Capitulo_1_2, Capitulo_1_3_1, Capitulo_1_3_2, Capitulo_1_4, Capitulo_2;
    public List<string> Capitulo_2_1, Capitulo_2_2, Capitulo_2_3_1, Capitulo_2_3_2, Capitulo_2_3_3, Capitulo_2_4;
    public List<string> Capitulo_2_4_1, Capitulo_3, Capitulo_3_1_1, Capitulo_3_1_2, Capitulo_3_2, Capitulo_3_3, Capitulo_3_3_1, Capitulo_3_3_2;
    public List<string> Capitulo_3_3_3;
    public List<string> Capitulo_4_A, Capitulo_4_B, Capitulo_4_C, Capitulo_4_D, Capitulo_4_E, Capitulo_5_Creditos;

            */

            //Prologo
            case "prologo":
                escolhaDialogicaList = listasDialogicasObject2.GetPrologo();
                break;

            //capitulo 1:
            case "Capitulo_1":
            escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_1();
                break;

            case "Capitulo_1_1":
            escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_1_1();
                break;

            case "Capitulo_1_2":
            escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_1_2();
                break;

            case "Capitulo_1_3_1":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_1_3_1();
                break;

            case "Capitulo_1_3_2":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_1_3_2();
                break;
            case "Capitulo_1_4":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_1_4();
                break;

            //Capitulo_2
            case "Capitulo_2":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_2();
                break;
            case "Capitulo_2_1":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_2_1();
                break;
            case "Capitulo_2_2":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_2_2();
                break;
            case "Capitulo_2_3_1":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_2_3_1();
                break;
            case "Capitulo_2_3_2":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_2_3_2();
                break;
            case "Capitulo_2_3_3":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_2_3_3();
                break;
            case "Capitulo_2_4":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_2_4();
                break;
            case "Capitulo_2_4_1":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_2_4_1();
                break;
            case "Capitulo_2_4_1_v2":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_2_4_1();
                break;
            case "Capitulo_2_4_1_v3":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_2_4_1();
                break;




            //Capitulo 3

            case "Capitulo_3":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_3();
                break;
            case "Capitulo_3_1_1":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_3_1_1();
                break;
            case "Capitulo_3_1_2":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_3_1_2();
                break;
            case "Capitulo_3_2":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_3_2();
                break;
            case "Capitulo_3_3":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_3_3();
                break;
            case "Capitulo_3_3_1":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_3_3_1();
                break;
            case "Capitulo_3_3_2":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_3_3_2();
                break;
            case "Capitulo_3_3_3":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_3_3_3();
                break;

            //Capitulo 4

            case "Capitulo_4_A":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_4_A();
                break;
            case "Capitulo_4_B":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_4_B();
                break;
            case "Capitulo_4_C":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_4_C();
                break;
            case "Capitulo_4_D":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_4_D();
                break;
            case "Capitulo_4_E":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_4_E();
                break;

            //Creditos
            case "Capitulo_5_Creditos":
                escolhaDialogicaList = listasDialogicasObject2.GetCapitulo_5_Creditos();
                break;


            //Listas de testes (localmente)
            case "frasesPadrao":
                escolhaDialogicaList = frasesPadrao;
                break;
            case "frasesUm":
            escolhaDialogicaList = frasesUm;
                break;
            case "frasesDois":
                escolhaDialogicaList = frasesDois;
                break;
            case "frasesTres":
                escolhaDialogicaList = frasesTres;
                break;
        }

        //Debug.Log("Estamos verificando em qual lista estamos trabalhando. A lista atual @: " + escolhaDialogicaList);
        return escolhaDialogicaList;
    }

    public void Rotas(string caminho1, string caminho2, string caminho3)
    {
        //Vai definir as rotas possiveis pelo jogador.
        rota1 = caminho1;
        rota2 = caminho2;
        rota3 = caminho3;
        Debug.Log("Estamos dentro de: 'Rotas'. O valor das rotas atual eh: Rota1: " + rota1 +" - Rota2: "+ rota2 + " - Rota3: " + rota3);

    }

    public void VerificaQualBotaoFoiPressinado()
    {

        //Esse metodo verifica qual botao foi pressionado e direciona pra qual rota devemos ir
        //Se algum botao foi pressioando, deve levar para a lista de frases desejada.

        //Escreva o destino possivel nas rotas e o metodo "DecisaoDialogica" levar@ o jogador para ela.

        Debug.Log("Estamos dentro do metodo 'VerificaQualBotaoFoiPressinado'. O valor da variavel 'algumBotaoFoiPressionado' eh: " + algumBotaoFoiPressionado);

        switch (algumBotaoFoiPressionado)
        {
            case "botao1":

                DecisaoDialogica(rota1);                
                Debug.Log("A rota escolhida foi: " + rota1);
                break;

            case "botao2":
                DecisaoDialogica(rota2);
                Debug.Log("A rota escolhida foi: " + rota2);
                break;
            case "botao3":
                DecisaoDialogica(rota3);
                Debug.Log("A rota escolhida foi: " + rota3);
                break;
            default:
                Debug.Log("Nenhuma rota foi escolhida ainda.");

                break;


        }

    }
}


                        