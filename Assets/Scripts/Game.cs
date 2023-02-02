using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;
using Unity.VisualScripting;

public class Game : MonoBehaviour
{

    /*Nesse script vamos tentar criar uma forma de gameplay. Inicialmente pretendo trabalhar criando um sistema de diálogo
     assim vou poder começar a ver as frases da gameplay. Mais pra frente quero trabalhar a parte de escolhas de diálogos
    E depois, trabalhar em cima dos avatares e cenários. 
    
    O sistema de gameplay é relativamente simples.*/


    //Todas as minhas variaveis globais para os metodos:

    //Define as listas que serão usadas para armazenar as frases
    public List<string> frasesPadrao;
    public List<string> frasesUm;
    public List<string> frasesDois;
    public List<string> frasesTres;

    //Rotas possiveis:
    public string rota1, rota2, rota3;

    //Criei uma array pra armazenar as escolhas possiveis, mas acho que nao vou usar dessa forma
    string[,] escolhaDialogoArray = new string[3, 3];

    //define os botões que serão usados para fazermos escolhas
    public Button escolhaN1, escolhaN2, escolhaN3;

    //define os TMP dos botões que serão usados para fazermos escolhas
    public TMP_Text escolhaNUMtmp, escolhaNDOIStmp, escolhaNTREStmp;
    TMP_Text textMeshProTela;

    //contador;
    private int contador = 0;
    //vai definir a escolha de rota que devemos inicializar/em que estamos atualmente (qual lista de frase devemos iniciar)
    public string escolhaDialogica = "add algum valor aqui";
    //bool pra travar de iniciar pela msm lista de frases:
    public bool escolhaDialogicaBool = true;
    //serve pra verificar em qual dentro do metodo 'DecisaoDialogicaList' em qual lista estamos
    public List<string> escolhaDialogicaList;
    //serve pra ver qual botao foi pressionado
    public string algumBotaoFoiPressionado;
    //serve pra ver se os botoes estao na tela
    public bool osBotoesEstaoAtivosNaTela;
    //Nao estou usando, mas serviria pra verificar o index do dialogo.
    public int currentDialogueIndex = 0;

    





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

        //texto.text = frases[contador];
        //Debug.Log(frasesPadrao[contador]);

        // Atribuindo valores numa array 1 linha 3 colunas:
        //escolhaDialogoArray[0, 0] = "frasesPadrao";
        escolhaDialogoArray[0, 0] = "Decisão 1 - escolha 1";
        escolhaDialogoArray[0, 1] = "Decisão 1 - escolha 2";
        escolhaDialogoArray[0, 2] = "Decisão 1 - escolha 3";

        escolhaDialogoArray[1, 0] = "Decisão 2 - escolha 1";
        escolhaDialogoArray[1, 1] = "Decisão 2 - escolha 2";
        escolhaDialogoArray[1, 2] = "Decisão 2 - escolha 3";


        // Esconder os botões de escolha inicialmente

        //Aqui eu instancio e encontro os botoes dentro da cena
        escolhaN1 = GameObject.Find("Botao_escolha1").GetComponent<Button>();
        escolhaN2 = GameObject.Find("Botao_escolha2").GetComponent<Button>();
        escolhaN3 = GameObject.Find("Botao_escolha3").GetComponent<Button>();

        //Aqui eu instancio e encontro os TMP dos botoes dentro da cena
        escolhaNUMtmp = GameObject.Find("Botao_escolha1TMP").GetComponent<TMP_Text>();
        escolhaNDOIStmp = GameObject.Find("Botao_escolha2TMP").GetComponent<TMP_Text>();
        escolhaNTREStmp = GameObject.Find("Botao_escolha3TMP").GetComponent<TMP_Text>();

        //Inicialmente os botoes nao aparecem na cena
        ButtonsOnScreen(false);

        //Vamos inputar o "frasesPadrao" como padrao para começar a calcular as frases e as rotas possiveis. 
        //Ou seja, vamos começar o jogo com essa lista de frases.

        if (escolhaDialogicaBool == true)
        {
            DecisaoDialogica("frasesPadrao");
            escolhaDialogicaBool = false;
        }
        else 
        {
            Debug.Log("Nao tem nenhuma lista padrão. A variavel 'escolhaDialogicaBool' está: " + escolhaDialogicaBool);
        }
        



    }







    void Update()
    {

        //Pega o componente de texto na tela e mostra a frase que eu atribuir dentro do TMP
        textMeshProTela = GameObject.Find("Diálogo").GetComponent<TMP_Text>();


        

        //Rota acrescentando dialogo com o botao esquerdo do mouse
        if (Input.GetMouseButtonDown(0))
        {


            //Esse sistema vai impedir o jogador de ultrapassar/retroceder o numero de frases dentro de uma lista
            //E vai começar a contar cada frase, permitindo a exibição na tela
            
            if (contador > DecisaoDialogicaList(escolhaDialogica).Count)
            {
                //verifica se o contador é maior que o numero de frases dentro da lista de frases
                //Se o contador for maior, entao deve parar de contar. Se for menor de 0 deve parar de contar tmb.    
                //Isso significa que o jogador nao vai poder avançar ou retroceder o dialogo se nao tiver mais dialogo algum.

                //isso deve parar de acrescentar valores ao clicar com o botao do mouse esquerdo
                contador = DecisaoDialogicaList(escolhaDialogica).Count;
                Debug.Log("Estamos parados na ultima frase da lista e não podemos avançar mais diálogos. O contador atual é: " + contador);
                
            }
            else 
            {
                //caso contrário só acrescente valores no contador.
                contador++;
                //contador = contador + 1 == acrescenta valores
                //contador = contador - 1== diminui valores
                //contador = DecisaoDialogicaList(escolhaDialogica).Count == trava o contador na contagem final da frase.

            }

            


            //Esse é o sistema de escolha de dialogo.
            //Estamos acrescentando dialogo

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
                        escolhaN1.onClick.AddListener(botao1Foipressionado);
                        escolhaN2.onClick.AddListener(botao2Foipressionado);
                        escolhaN3.onClick.AddListener(botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("frasesPadrao", "frasesDois", "frasesTres");

                        //Zera o contador, sendo possível recomeçar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    } 
                    break;

                case "frasesPadrao":
                    // Ações a serem executadas quando a opção 1 é selecionada
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
                        escolhaN1.onClick.AddListener(botao1Foipressionado);
                        escolhaN2.onClick.AddListener(botao2Foipressionado);
                        escolhaN3.onClick.AddListener(botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("frasesUm", "frasesDois", "frasesTres");

                        //Zera o contador, sendo possível recomeçar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "frasesDois":
                    // Ações a serem executadas quando a opção 1 é selecionada
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
                    // Ações a serem executadas quando a opção 1 é selecionada
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
                    Debug.Log("Nenhuma opção escolhida");
                    break;


            }


        }
        //fim da rota acrescentando dialogo

        //-----------------------------------------------------------------

        //Começando a rota decrescendo o dialogo
        if (Input.GetMouseButtonDown(1))
        {

            
            //escolhaDialogica = "frasesPadrao";

            if (contador <= 0)
            {
                //verifica se o contador é maior que o numero de frases dentro da lista de frases
                //Se o contador for maior, entao deve parar de contar. Se for menor de 0 deve parar de contar tmb.    
                //Isso significa que o jogador nao vai poder avançar ou retroceder o dialogo se nao tiver mais dialogo algum.

                //isso deve parar de acrescentar valores ao clicar com o botao do mouse esquerdo
                contador = 0;
                Debug.Log("Estamos parados na primeira frase da lista e não podemos retroceder mais diálogos. O contador atual é: " + contador);

            }
            else
            {
                //caso contrário só acrescente valores no contador.
                contador--;
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
                        Debug.Log("Estamos no contador++ e os botoes devem desaparecer");
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
                        escolhaN1.onClick.AddListener(botao1Foipressionado);
                        escolhaN2.onClick.AddListener(botao2Foipressionado);
                        escolhaN3.onClick.AddListener(botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("frasesPadrao", "frasesDois", "frasesTres");

                        //Zera o contador, sendo possível recomeçar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        
                    }
                    break;

                case "frasesPadrao":
                    // Ações a serem executadas quando a opção 1 é selecionada
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
                        escolhaN1.onClick.AddListener(botao1Foipressionado);
                        escolhaN2.onClick.AddListener(botao2Foipressionado);
                        escolhaN3.onClick.AddListener(botao3Foipressionado);

                        //Vai definir quais rotas serao possiveis:
                        Rotas("frasesUm", "frasesDois", "frasesTres");

                        //Zera o contador, sendo possível recomeçar a ver as frases.
                        //Precisamos disso aqui, pq se nao vamos misturar a contagem de outra lista de frases
                        //Pq quando redirecionamos para outra lista de frases, o contador deve ser 0
                        //Por isso precisamos zerar o contador.
                        //contador = 0;
                    }

                    break;

                case "frasesDois":
                    // Ações a serem executadas quando a opção 1 é selecionada
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
                    // Ações a serem executadas quando a opção 1 é selecionada
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
                    Debug.Log("Nenhuma opção escolhida");
                    break;


            }



        }



    }

    //Lista de metodos

    public void ButtonsOnScreen(bool enable)
    {
        //esse metodo ativa os botoes na tela
        escolhaN1.gameObject.SetActive(enable);
        escolhaN2.gameObject.SetActive(enable);
        escolhaN3.gameObject.SetActive(enable);


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

    public void botao1Foipressionado() 
    {
        //Verifica se o botao 1 foi pressionado            
        algumBotaoFoiPressionado = "botao1";
        Debug.Log("botao 1 foi pressionado.");
        Debug.Log("O valor da variavel 'algumBotaoFoiPressionado' é: " + algumBotaoFoiPressionado);
        VerificaQualBotaoFoiPressinado();
        escolhaN1.gameObject.SetActive(false);
        escolhaN2.gameObject.SetActive(false);
        escolhaN3.gameObject.SetActive(false);
        textMeshProTela.text = "Clique para continuar";
        contador = 0;


    }
    public void botao2Foipressionado()
    {
        //Verifica se o botao 2 foi pressionado    
        algumBotaoFoiPressionado = "botao2";
        Debug.Log("botao 2 foi pressionado.");
        Debug.Log("O valor da variavel 'algumBotaoFoiPressionado' é: " + algumBotaoFoiPressionado);
        VerificaQualBotaoFoiPressinado();
        escolhaN1.gameObject.SetActive(false);
        escolhaN2.gameObject.SetActive(false);
        escolhaN3.gameObject.SetActive(false);
        textMeshProTela.text = "Clique para continuar";
        contador = 0;
    }
    public void botao3Foipressionado()
    {
        //Verifica se o botao 3 foi pressionado    
        algumBotaoFoiPressionado = "botao3";
        Debug.Log("botao 3 foi pressionado.");
        Debug.Log("O valor da variavel 'algumBotaoFoiPressionado' é: " + algumBotaoFoiPressionado);
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
        //Aqui instanciamos um valor que definirá para qual rota iremos, ou seja
        //para a variavel global da escolhaDialogica, instanciada globalmente no inicio do codigo.
        //Combinaremos esse metodo com o resultado dos botoes, criando um caminho definido pelo jogador
        escolhaDialogica = decisao;
        Debug.Log("Estamos em 'DecisaoDialogica' e a rota que estamo agora é: " + escolhaDialogica);
    }

    public List<string> DecisaoDialogicaList(string decisaoList)
    {
        //Vai retornar em qual lista estamos atualmente
        //Serve pra evitar avançar ou retroceder demais no diálogo, dependendo da qtd de frases na lista.

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

        Debug.Log("Estamos verificando em qual lista estamos trabalhando. A lista atual é: " + escolhaDialogicaList);
        return escolhaDialogicaList;
    }

    public void Rotas(string caminho1, string caminho2, string caminho3)
    {
        //Vai definir as rotas possiveis pelo jogador.
        rota1 = caminho1;
        rota2 = caminho2;
        rota3 = caminho3;
        Debug.Log("Estamos dentro de: 'Rotas'. O valor das rotas atual é: Rota1: " + rota1 +" - Rota2: "+ rota2 + " - Rota3: " + rota3);

    }

    public void VerificaQualBotaoFoiPressinado()
    {

        //Esse metodo verifica qual botao foi pressionado e direciona pra qual rota devemos ir
        //Se algum botao foi pressioando, deve levar para a lista de frases desejada.

        //Escreva o destino possivel nas rotas e o metodo "DecisaoDialogica" levará o jogador para ela.

        Debug.Log("Estamos dentro do metodo 'VerificaQualBotaoFoiPressinado'. O valor da variavel 'algumBotaoFoiPressionado' é: " + algumBotaoFoiPressionado);

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
    //Preciso de um metodo pra receber as rotas possiveis
    //E preciso de um metodo pra colocar dentro dos 'botao1Foipressionado' para receber as rotas dadas
    //E redirecionar para o caminho dela


    /*Bugs para resolver:
    1-Esconder os botoes caso eu volte e eles ja tenham aparecido na tela. - ok
    2-Tentar travar o avanço de dialogo apos acabar as frases dentro da lista de frases, pois
    fica adicionando valores em um round que nao vai ser usado (o contador) e pra voltar eu tenho que ficar
    clicando varias vezes. ok
    3-Fazer o sistema de rota de lista de frases funcionar.
    
    Onde parei: estou tentando fazer o console me mostrar que os botoes foram precionados e que a variavel: algumBotaoFoiPressionado
    Tem conteúdo. Se eu conseguir fazer essa variavel pegar o tipo de botao que tem nela, o metodo 'VerificaQualBotaoFoiPressinado'
    vai funcionar, levando o jogador pra rota selecionada.
     
    ------------

    Atualmente eu to percebendo alguns probleminhas:
    1-Preciso pensar em uma forma de zerar o contador toda vez que uma rota for iniciada
    Mas esse contador precisa ser zerado uma única vez.

    2-O problema que estou enfrentando nas rotas é simples:
    Antes os botoes estavam linkados com esse código, isso significa que toda vez que eu apertava os botoes as variaveis globais eram resetadas.
    Isso quer dizer que o sistema de links que me leva para outra rota é cancelado, mesmo estando "tudo funcionando". Dessa forma, é necessário
    pensar em uma forma de linkar o resultado de 'VerificaQualBotaoFoiPressinado' e linkar com os botoes para nos enviar para as rotas desejadas.

    Para os botoes funcionarem creio eu que eu precise direcionar na cena o que cada botao vai fazer, mas eu nao poderei usar esse codigo.
    Entao terei que criar outro script que reconhecera qual botao estamos clicando e para onde ele deve nos levar. É importante lembrar que nao
    devemos reiniciar a cena quando apertamos um botao, apenas linkar para um lista de frases diferente.

    ---------

    Se isso der certo, o esqueleto do jogo estará pronto. Falta apenas isso pra fazer funcionar.
    Depois disso, partirei pra construir um sistema de save, o menu de pausa, loading, trazer os assets para o game, 
    construir um sistema que verifica em qual cenário e qual avatar deve aparecer na tela, construir um sistema de som,
    integrar com a API do spotify e após colocar todo o diálogo, o jogo estará finalmente pronto. Não falta muita 
    coisa, mas se tudo isso estiver pronto a tempo, significa que terei cumprido meu objetivo.

    Após o jogo estar pronto, estarei lançando a plataforma online da saphire, o patreon, o itch.io e fazendo uma live pra comemorar 
    a construção da nova fase da saphire game studio. Em breve seremos fortes o bastante para crescermos e termos renda com o estúdio.
     
     */


}







