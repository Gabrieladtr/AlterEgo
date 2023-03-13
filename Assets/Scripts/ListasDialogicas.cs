using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListasDialogicas : MonoBehaviour
{

    public List<string> frasesPadrao;
    public List<string> CAPITULO_1_A_SAIDA_D_SOV;

    public List<string> GetListaDialogos()
    {
        frasesPadrao = new List<string>();

        // adicionar itens � listaDialogos
        frasesPadrao.Add("Cliquei novamente para iniciar");
        frasesPadrao.Add("CyberCity... a cidade dos sonhos.");
        frasesPadrao.Add("A cidade onde voc� n�o morre, n�o possui doen�as, pobreza, guerra ou qualquer outro problema que h� na realidade. ");
        frasesPadrao.Add("Tudo isso gra�as ao SOV � Sistema Operacional Virtual e seu complemento, o Amotine. ");
        frasesPadrao.Add("Ambas as tecnologias da corpora��o LIFE.");
        frasesPadrao.Add("Dentro do SOV, na CyberCity as pessoas podem viver em paz.");
        frasesPadrao.Add("Enquanto estava a caminho de seu trabalho, como engenheiro de computa��o, Yael passa por uma m�quina de refrigerantes e v� ela dando glitch.");
        frasesPadrao.Add("Yael decide ir verificar a m�quina e acaba descobrindo uma forma de sair do SOV.");
        frasesPadrao.Add("Ao digitar um valor menor do que qualquer produto, ele acorda fora da CyberCity na cidade de Omskvi, na antiga Petrov, pa�s que ficava localizado no leste europeu e v� toda a mata tomando conta da cidade. ");
        frasesPadrao.Add("Tinha descoberto pela primeira vez, que houve uma guerra nuclear, pois havia sido uma das primeiras cobaias a ser imputada dentro do SOV, pois havia sido um prisioneiro americo-cairano no Leste Europeu.");
        frasesPadrao.Add("Antes de desmaiar, devido seu debilitado corpo, v� um homem com uma m�scara de p�ssaro e apaga.");
        frasesPadrao.Add("Acorda em um acampamento desconhecido e frio, come�a ent�o a buscar respostas para todas as suas d�vidas.");
        //msg no console
        Debug.Log("Dados adicionados em ListasDialogicas.frasesPadrao.");

        return frasesPadrao;
    }

    public List<string> GetListaCAPITULO_1_A_SAIDA_D_SOV()
    {
        CAPITULO_1_A_SAIDA_D_SOV = new List<string>();

        // adicionar itens � listaDialogos
        CAPITULO_1_A_SAIDA_D_SOV.Add("P�ssaro � Ei ei, n�o precisa se levantar agora, seu corpo precisa de mais algumas horas at� se adaptar novamente � realidade.");
        CAPITULO_1_A_SAIDA_D_SOV.Add("Yael � Eu... eu n�o sei o que houve...");
        CAPITULO_1_A_SAIDA_D_SOV.Add("P�ssaro � Voc� acordou, � isso que houve.");
        CAPITULO_1_A_SAIDA_D_SOV.Add("Yael � Eu estava em um sonho?");
        CAPITULO_1_A_SAIDA_D_SOV.Add("P�ssaro � N�o, voc� estava no SOV. � uma realidade virtual, j� est� l� a tanto tempo que nem lembra direito que existe outra realidade n�?!");
        CAPITULO_1_A_SAIDA_D_SOV.Add("Yael � Eu acredito que sim... n�o entendo o que aconteceu, eu entrei em contato com uma m�quina de refri...");
        CAPITULO_1_A_SAIDA_D_SOV.Add("P�ssaro � Refrigerantes! Quem diria n�o � mesmo? Foi o mesmo comigo e com o meu irm�o, tem uma falha de cenografia dentro do SOV que te permite sair do sistema operacional atrav�s dessas m�quinas. ");
        CAPITULO_1_A_SAIDA_D_SOV.Add("Yael � hum... mas como?");
        CAPITULO_1_A_SAIDA_D_SOV.Add("P�ssaro � Meu irm�o � engenheiro de software, ele criou uma falha na m�quina de refrigerantes para que pud�ssemos sair de l�, assim como outras pessoas que acharem a m�quina.");
        CAPITULO_1_A_SAIDA_D_SOV.Add("Yael � Voc�s conseguiram criar uma falha no sistema e conseguiram escapar? Genial...");
        CAPITULO_1_A_SAIDA_D_SOV.Add("P�ssaro � N�s estamos apenas sobrevivendo.");
        CAPITULO_1_A_SAIDA_D_SOV.Add("Yael � Voc�s s�o quantos? Voc� e seu irm�o... tem mais algu�m?");
        CAPITULO_1_A_SAIDA_D_SOV.Add("P�ssaro � Somos apenas tr�s, contado comigo. N�s nos viramos para sobreviver nessa cidade, evitando radioatividade e usando as m�scaras como disfarce contra os drones da LIFE.");
        CAPITULO_1_A_SAIDA_D_SOV.Add("Yael � Isso explica aquela m�scara estranha de p�ssaro? A prop�sito, qual o seu nome?");
        CAPITULO_1_A_SAIDA_D_SOV.Add("P�ssaro � Aquela m�scara estranha me mante vivo, exalta quem eu tenho que ser para sobreviver. Sugiro voc� construir a sua quando estiver pronto! E meu nome � Wing, prazer em conhec�-lo. Agora, qual o seu nome?");
        CAPITULO_1_A_SAIDA_D_SOV.Add("Yael � Meu nome � Yael. Bem, vou pensar sobre isso, obrigado pela ajuda! Sem voc� eu j� teria morrido.");
        CAPITULO_1_A_SAIDA_D_SOV.Add("P�ssaro � N�o se preocupe, estamos precisando de mais membros. Mas se quiser ficar, vai ter que convencer os outros. Voc� precisa conhecer eles e apresentar a todos. Dizer quem � e o que busca. Quando estiver pronto, me chame.");
        CAPITULO_1_A_SAIDA_D_SOV.Add("Yael � vou chamar, obrigado por tudo de novo.");
        //msg no console
        Debug.Log("Dados adicionados em ListasDialogicas.CAPITULO_1_A_SAIDA_D_SOV.");

        return CAPITULO_1_A_SAIDA_D_SOV;
    }



}
