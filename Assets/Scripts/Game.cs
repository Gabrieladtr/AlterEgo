using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

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

    public ListasDialogicas listasDialogicasObject;

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
    public List<string> escolhaDialogicaList;
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
        /*
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
        frasesPadrao.Add("frasesPadrao - Escolha 1");
        frasesPadrao.Add("frasesPadrao - teste de frase 10");
        frasesPadrao.Add("frasesPadrao - Escolha 2");
        */

        frasesPadrao.Add("Cliquei novamente para iniciar");
        frasesPadrao.Add("CyberCity... a cidade dos sonhos.");
        frasesPadrao.Add("A cidade onde você não morre, não possui doenças, pobreza, guerra ou qualquer outro problema que há na realidade. ");
        frasesPadrao.Add("Tudo isso graças ao SOV – Sistema Operacional Virtual e seu complemento, o Amotine. ");
        frasesPadrao.Add("Ambas as tecnologias da corporação LIFE.");
        frasesPadrao.Add("Dentro do SOV, na CyberCity as pessoas podem viver em paz.");
        frasesPadrao.Add("Enquanto estava a caminho de seu trabalho, como engenheiro de computação, Yael passa por uma máquina de refrigerantes e vê ela dando glitch.");
        frasesPadrao.Add("Yael decide ir verificar a máquina e acaba descobrindo uma forma de sair do SOV.");
        frasesPadrao.Add("Ao digitar um valor menor do que qualquer produto, ele acorda fora da CyberCity na cidade de Omskvi, na antiga Petrov, país que ficava localizado no leste europeu e vê toda a mata tomando conta da cidade. ");
        frasesPadrao.Add("Tinha descoberto pela primeira vez, que houve uma guerra nuclear, pois havia sido uma das primeiras cobaias a ser imputada dentro do SOV, pois havia sido um prisioneiro americo-cairano no Leste Europeu.");
        frasesPadrao.Add("Antes de desmaiar, devido seu debilitado corpo, vê um homem com uma máscara de pássaro e apaga.");
        frasesPadrao.Add("Acorda em um acampamento desconhecido e frio, começa então a buscar respostas para todas as suas dúvidas.");


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
        //Caso contrário, nao faz nada.

        if (escolhaDialogicaBool == true)
        {
            //vai add o valor 'frasesPadrao' em 'escolhaDialogica'
            DecisaoDialogica("frasesPadrao");
            
            //vai travar, nao permitindo que nada mais seja add em 'escolhaDialogica', funcionando apenas 1 vez.
            escolhaDialogicaBool = false;

            Debug.Log("Estamos dentro do primeiro IF, onde escolhemos o 'frasesPadrao', Game.escolhaDialogicaBool: " + escolhaDialogicaBool);
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
                case "frasesUm":

                    if (contador < frasesUm.Count && contador != frasesUm.Count)
                    {
                        Debug.Log(frasesUm[contador]);
                        textMeshProTela.text = frasesUm[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    } else if (contador == frasesUm.Count)
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

                case "frasesPadrao":

                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < listasDialogicasObject.GetListaDialogos().Count && contador != listasDialogicasObject.GetListaDialogos().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetListaDialogos()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetListaDialogos()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);
                        
                    }
                    else if (contador == listasDialogicasObject.GetListaDialogos().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("frasesUm", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("frasesUm", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "frasesDois":
                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    //listasDialogicasObject

                    
                    if (contador < listasDialogicasObject.GetListaCAPITULO_1_A_SAIDA_D_SOV().Count && contador != listasDialogicasObject.GetListaCAPITULO_1_A_SAIDA_D_SOV().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetListaCAPITULO_1_A_SAIDA_D_SOV()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetListaCAPITULO_1_A_SAIDA_D_SOV()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetListaCAPITULO_1_A_SAIDA_D_SOV().Count)
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


            switch (escolhaDialogica)
            {
                case "frasesUm":

                    if (contador < frasesUm.Count && contador != frasesUm.Count)
                    {
                        Debug.Log(frasesUm[contador]);
                        textMeshProTela.text = frasesUm[contador];
                        Debug.Log("Estamos no contador-- e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == frasesUm.Count)
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
                        
                    }
                    break;

                case "frasesPadrao":

                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    if (contador < listasDialogicasObject.GetListaDialogos().Count && contador != listasDialogicasObject.GetListaDialogos().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetListaDialogos()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetListaDialogos()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetListaDialogos().Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesPadrao.Count";
                        Debug.Log("Estamos no contador == frases.Count e os botoes devem aparecer");
                        //Vai mostrar os botoes na tela
                        ButtonsOnScreen(true);

                        //Vai definir uma mensagem para cada botao na tela.
                        ButtonsMessages("frasesUm", "frasesDois", "frasesTres");

                        //Deve retornar qual botao foi pressionado
                        escolhaN1.onClick.AddListener(Botao1Foipressionado);
                        escolhaN2.onClick.AddListener(Botao2Foipressionado);
                        escolhaN3.onClick.AddListener(Botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("frasesUm", "frasesDois", "frasesTres");

                        //Zera o contador, sendo poss@vel recome@ar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "frasesDois":
                    // A@@es a serem executadas quando a op@@o 1 @ selecionada
                    //listasDialogicasObject


                    if (contador < listasDialogicasObject.GetListaCAPITULO_1_A_SAIDA_D_SOV().Count && contador != listasDialogicasObject.GetListaCAPITULO_1_A_SAIDA_D_SOV().Count)
                    {
                        Debug.Log(listasDialogicasObject.GetListaCAPITULO_1_A_SAIDA_D_SOV()[contador]);
                        textMeshProTela.text = listasDialogicasObject.GetListaCAPITULO_1_A_SAIDA_D_SOV()[contador];
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == listasDialogicasObject.GetListaCAPITULO_1_A_SAIDA_D_SOV().Count)
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
                        Debug.Log("Estamos no contador-- e os botoes devem desaparecer");
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
                    //Debug.Log("Nenhuma opcao escolhida");
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

        switch (decisaoList) 
        {
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







