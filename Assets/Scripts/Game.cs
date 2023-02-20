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

    //Controla de o pause est@ ativado ou n@o
    public bool pauseActive = false;

    //Vai ser responsavel por salvar o progresso do jogador:
    public string save1;
    public static TMP_Text saving1TMP, saving2TMP, saving3TMP, snTMP, loadTMP;

    //chave que verifica se salvamos ou nao o jogo
    public static bool snBool = false;

    //slot para salvamentos do jogo
    public static string slotSaveGame;

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
        frasesPadrao.Add("frasesPadrao - Escolha 1");
        frasesPadrao.Add("frasesPadrao - teste de frase 10");
        frasesPadrao.Add("frasesPadrao - Escolha 2");

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

        /*

        //verifico se temos os botoes/tmp de saving na tela. Se sim carregamos os saves do jogador.

        

        */

        //Vamos inputar o "frasesPadrao" como padrao para come@ar a calcular as frases e as rotas possiveis. 
        //Ou seja, vamos come@ar o jogo com essa lista de frases.


        

        if (escolhaDialogicaBool == true)
        {
            //vai add o valor 'frasesPadrao' em 'escolhaDialogica'
            DecisaoDialogica("frasesPadrao");
            Debug.Log("Estamos dentro do primeiro IF, onde escolhemos o 'frasesPadrao'");
            //vai travar, nao permitindo que nada mais seja add em 'escolhaDialogica', funcionando apenas 1 vez.
            escolhaDialogicaBool = false;
        }
        else 
        {
            //Debug.Log("Nao tem nenhuma lista padr@o. A variavel bool 'escolhaDialogicaBool' est@: " + escolhaDialogicaBool +  ". A EscolhaDialogica @: " + escolhaDialogica);
            //escolhaDialogicaBool = true;
        }

    }






    void Update()
    {

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
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
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

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesDois.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        ButtonsOnScreen(true);
                        ButtonsMessages("Gabriel", "Joao", "teste");

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

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesTres.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        ButtonsOnScreen(true);
                        ButtonsMessages("Gabriel", "Joao", "teste");

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
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
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
                    if (contador < frasesPadrao.Count && contador != frasesPadrao.Count)
                    {
                        Debug.Log(frasesPadrao[contador]);
                        textMeshProTela.text = frasesPadrao[contador];
                        Debug.Log("Estamos no contador-- e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == frasesPadrao.Count)
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
                    if (contador < frasesDois.Count && contador != frasesDois.Count)
                    {
                        Debug.Log(frasesDois[contador]);
                        textMeshProTela.text = frasesDois[contador];
                        Debug.Log("Estamos no contador-- e os botoes devem desaparecer");
                        ButtonsOnScreen(false);

                    }
                    else if (contador == frasesDois.Count)
                    {
                        //decisao dialogica aqui

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesDois.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        ButtonsOnScreen(true);
                        ButtonsMessages("Gabriel", "Joao", "teste");

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

                        textMeshProTela.text = "Nesse momento estamos na msm contagem do contador e frasesTres.Count";
                        Debug.Log("Estanos no contador == frases.Count e os botoes devem aparecer");
                        ButtonsOnScreen(true);
                        ButtonsMessages("Gabriel", "Joao", "teste");

                    }
                    break;

                default:
                    //valor que sera atribuido de forma padrao
                    //Debug.Log("Nenhuma opcao escolhida");
                    break;


            }

            

        }


        //------------------------------------------Fim do sistema de escolha dialogica------------------------------------------
        

        //controlamos se o pause est@ ativo ou nao

        if (Input.GetKeyDown(KeyCode.Escape) && pauseActive == false)
        {
            Debug.Log("O menu de pausa deve ser aberto.");
            SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
            pauseActive = true;

        } else if (Input.GetKeyDown(KeyCode.Escape) && pauseActive == true)
        {

            Debug.Log("O menu de pausa deve ser fechado.");
            SceneManager.UnloadSceneAsync("PauseMenu", UnloadSceneOptions.None);
            pauseActive = false;


        }

       


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

    public void DecisaoDialogica(string decisao) {
        //Aqui instanciamos um valor que definir@ para qual rota iremos, ou seja
        //para a variavel global da escolhaDialogica, instanciada globalmente no inicio do codigo.
        //Combinaremos esse metodo com o resultado dos botoes, criando um caminho definido pelo jogador
        escolhaDialogica = decisao;
        
        Debug.Log("Estamos em 'DecisaoDialogica' e a rota que estamos agora eh: " + escolhaDialogica);

        //Espa@o do sistema de save.
        faseAtual2 = decisao;
        //SaveGame();
        

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

    //-------------------------------------Sistema de save ------------------------------------


    public void SimFoiPressionado(bool chave)
    {
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

    public void SaveGame() 
    {
        

        //esse metodo sera capaz de entender em qual fase estamos e deve salvar o jogo de acordo com a fase/slot escolhido.

        Debug.Log("estamos em 'SaveGame' e a 'escolhaDialogica' eh: " + faseAtual2 +" 'vazio' " + ". Nenhuma informacao foi salva ainda. A fase atual eh: " + faseAtual2);


        //salva o jogo automaticamente, se alguma frase listada aparecer nesse switch. Pois chama o @Save1Progress().
            switch (faseAtual2)
            {
                case "frasesUm":
                Debug.Log("Estamos em SaveGame/FrasesUm/Switch. 'slotSaveGame': " + slotSaveGame + " 'faseAtual2': "+ faseAtual2 + ". SimFoiPressionado: " + snBool);

                    if (snBool == true)
                    {
                        Save1Progress(slotSaveGame, faseAtual2);
                        
                }
                else { Debug.Log("Estamos em 'SaveGame/frasesUm'. O slot para salvar nao foi encontrado ou o snbool nao eh true. Estamos na 'EscolhaDialogica': " + faseAtual2); }
                    
                break;

                case "frasesDois":
                Debug.Log("Estamos em SaveGame/FrasesUm/Switch. 'slotSaveGame': " + slotSaveGame + " 'faseAtual2': "+ faseAtual2 + ". SimFoiPressionado: " + snBool);

                    if (slotSaveGame != null && snBool == true)
                    {
                        Save1Progress(slotSaveGame, faseAtual2);
                        //SimFoiPressionado(false);
                }
                else { Debug.Log("Estamos em 'SaveGame/frasesDois'. O slot para salvar nao foi encontrado ou o snbool nao eh true. Estamos na 'EscolhaDialogica': " + faseAtual2); }

                break;

                default:
                    Debug.Log("Estamos em 'SaveGame()' e nenhum save foi salvo. Escolha dialogica: " + faseAtual2);
                    break;

            }
        


    }


    public void Save1Progress(string slot, string listaAtual)
    {
        
        //vai salvar o progresso do jogo e desativar a chave 'snBool', permitindo salvar em algum outro momento.

        //Vamos usar o 'slot' para o lugar de salvamento
        //Vamos usar o 'listaAtual' para salvar no slot.

        PlayerPrefs.SetString(slot, listaAtual);
        //for@a o salvamento
        PlayerPrefs.Save();
     
        saving1TMP = GameObject.Find("SalvarProgressoGameTMP").GetComponent<TMP_Text>();
        saving1TMP.text = "Save 1: " + PlayerPrefs.GetString(slot, "Nenhum save encontrado") + ". Slot: " + slot;
        Debug.Log("Dados salvos no slot: " + slot+". Nome da lista salva: " + listaAtual);
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

    /*
    public void LoadSavesToScreen()
    {
        //Esse metodo apenas carrega os metodos para a tela de loading ao iniciar a tela.
        //deve ser inicializado no start.

        saving1TMP = GameObject.Find("SaveLoading1_TMP").GetComponent<TMP_Text>();
        saving1TMP.text = "Load 1: " + PlayerPrefs.GetString("Espaco1", "Nenhum save encontrado ") + " - Slot: Espaco 1";

        saving2TMP = GameObject.Find("SaveLoading2_TMP").GetComponent<TMP_Text>();
        saving2TMP.text = "Load 2: " + PlayerPrefs.GetString("Espaco2", "Nenhum save encontrado ") + " - Slot: Espaco 2";

        saving3TMP = GameObject.Find("SaveLoading3_TMP").GetComponent<TMP_Text>();
        saving3TMP.text = "Load 3: " + PlayerPrefs.GetString("Espaco3", " Nenhum save encontrado ") + " - Slot: Espaco 3";

    }
    */


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














    //Preciso de um metodo pra receber as rotas possiveis
    //E preciso de um metodo pra colocar dentro dos 'botao1Foipressionado' para receber as rotas dadas
    //E redirecionar para o caminho dela


    /*Bugs para resolver:
    1-Esconder os botoes caso eu volte e eles ja tenham aparecido na tela. - ok
    2-Tentar travar o avan@o de dialogo apos acabar as frases dentro da lista de frases, pois
    fica adicionando valores em um round que nao vai ser usado (o contador) e pra voltar eu tenho que ficar
    clicando varias vezes. ok
    3-Fazer o sistema de rota de lista de frases funcionar.
    
    Onde parei: estou tentando fazer o console me mostrar que os botoes foram precionados e que a variavel: algumBotaoFoiPressionado
    Tem conte@do. Se eu conseguir fazer essa variavel pegar o tipo de botao que tem nela, o metodo 'VerificaQualBotaoFoiPressinado'
    vai funcionar, levando o jogador pra rota selecionada.
     
    ------------

    Atualmente eu to percebendo alguns probleminhas:
    1-Preciso pensar em uma forma de zerar o contador toda vez que uma rota for iniciada
    Mas esse contador precisa ser zerado uma @nica vez.

    2-O problema que estou enfrentando nas rotas @ simples:
    Antes os botoes estavam linkados com esse c@digo, isso significa que toda vez que eu apertava os botoes as variaveis globais eram resetadas.
    Isso quer dizer que o sistema de links que me leva para outra rota @ cancelado, mesmo estando "tudo funcionando". Dessa forma, @ necess@rio
    pensar em uma forma de linkar o resultado de 'VerificaQualBotaoFoiPressinado' e linkar com os botoes para nos enviar para as rotas desejadas.

    Para os botoes funcionarem creio eu que eu precise direcionar na cena o que cada botao vai fazer, mas eu nao poderei usar esse codigo.
    Entao terei que criar outro script que reconhecera qual botao estamos clicando e para onde ele deve nos levar. @ importante lembrar que nao
    devemos reiniciar a cena quando apertamos um botao, apenas linkar para um lista de frases diferente.

    ---------

    Se isso der certo, o esqueleto do jogo estar@ pronto. Falta apenas isso pra fazer funcionar.
    Depois disso, partirei pra construir um sistema de save, o menu de pausa, loading, trazer os assets para o game, 
    construir um sistema que verifica em qual cen@rio e qual avatar deve aparecer na tela, construir um sistema de som,
    integrar com a API do spotify e ap@s colocar todo o di@logo, o jogo estar@ finalmente pronto. N@o falta muita 
    coisa, mas se tudo isso estiver pronto a tempo, significa que terei cumprido meu objetivo.

    Ap@s o jogo estar pronto, estarei lan@ando a plataforma online da saphire, o patreon, o itch.io e fazendo uma live pra comemorar 
    a constru@@o da nova fase da saphire game studio. Em breve seremos fortes o bastante para crescermos e termos renda com o est@dio.
    
    --------------------
    onde parei:

    Cara nao entendo o pq, mas o playerprefs fica mantendo o valor mesmo j@ tendo apagado e tendo apagado at@ a vari@vel que o valor se encotrava
    Ele n@o grava de forma alguma um valor que est@ dentro de uma vari@vel, ele n@o permite sobreescrever. @ como se ele gravasse uma vez e n@o permitisse
    mais gravar. Vi coisas estranhas hoje: o debug informar 2 valores diferentes ao mesmo tempo para um @nico debug, ou seja bugadasso.
    N@o sei se vale a pena continuar tentando contruir sistemas para o playerprefs, talvez seja melhor tentar buscar outra forma de armazenar dados.
    Pq sinceramente, depois de 2 dias trabalhando o que eu sinto @ que essa fun@@o @ incompleta, parece que tem falhas e grandes falhas.

    Vou dar mais uma pesquisada sobre pra ver se consigo resolver e se tem problemas cr@nicos. E sim, pensei de tudo: limpar o cache, limpar os dados
    salvos, reiniciar, apagar a variavel, tentar acessar em outra classe. Cara eu to exausto. Quando eu pensei que tinha conseguido,
    pq teve uma @nica hora que funcionou e depois n@o funcionou mais. Em resumo, estou cansado e acabado de tanto tentar fazer isso funcionar.

    Amanh@ se der tempo pesquiso pra ver se consigo resolver, caso n@o... vou s@ tentar outra forma.

    ----
    Eu tenho usado a key 'save_1' para salvar os dados. De repente esse @ o problema. Estou usando repetidamente o mesmo save.
    Estou com algumas ideias novas. A primeira @ tentar colocar o m@todo de save dentro do m@todo de carregar a fase atual e usar o playerprefs.save()
    para tentar garantir que os dados foram salvos.

    -----------------
    o metodo savegame esta quase pronto. S@ linkar o snbool com o botao de sim e criar botoes para os slots
    e na teoria vai estar pronto. Criar uma forma de apagar os saves tmb, colocar o simbolo de uma lixeira.



     */


}







