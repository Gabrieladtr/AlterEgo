using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListasDialogicas : MonoBehaviour
{

    public List<string> frasesPadrao;
    public List<string> CAPITULO_1_A_SAIDA_DO_SOV = new List<string>();
    public List<string> frasesTres = new List<string>();

    public List<string> GetListaDialogoInicial()
    {
        frasesPadrao = new List<string>();

        // adicionar itens � listaDialogos
        frasesPadrao.Add("Cliquei novamente para iniciar");
        frasesPadrao.Add("CyberCity... a cidade dos sonhos.");
        frasesPadrao.Add("A cidade onde você não morre, não possui doenças, pobreza, guerra ou qualquer outro problema que há na realidade. ");
        frasesPadrao.Add("Tudo isso graças ao SOV - Sistema Operacional Virtual e seu complemento, o Amotine. ");
        frasesPadrao.Add("Ambas as tecnologias da corporação LIFE.");
        frasesPadrao.Add("Dentro do SOV, na CyberCity as pessoas podem viver em paz.");
        frasesPadrao.Add("Enquanto estava a caminho de seu trabalho, como engenheiro de computação, Yael passa por uma máquina de refrigerantes e vê ela dando glitch.");
        frasesPadrao.Add("Yael decide ir verificar a máquina e acaba descobrindo uma forma de sair do SOV.");
        frasesPadrao.Add("Ao digitar um valor menor do que qualquer produto, ele acorda fora da CyberCity na cidade de Omskvi, na antiga Petrov, país que ficava localizado no leste europeu e vê toda a mata tomando conta da cidade. ");
        frasesPadrao.Add("Tinha descoberto pela primeira vez, que houve uma guerra nuclear, pois havia sido uma das primeiras cobaias a ser imputada dentro do SOV, pois havia sido um prisioneiro americo-cairano no Leste Europeu.");
        frasesPadrao.Add("Antes de desmaiar, devido seu debilitado corpo, vê um homem com uma máscara de pássaro e apaga.");
        frasesPadrao.Add("Acorda em um acampamento desconhecido e frio, começa então a buscar respostas para todas as suas dúvidas.");
    
        
        
        //msg no console
        Debug.Log("Dados adicionados em ListasDialogicas.frasesPadrao.");

        return frasesPadrao;
    }

    public List<string> GetListaCAPITULO_1_A_SAIDA_D_SOV(){
        
        frasesTres.Add("Pássaro – Ei ei, não precisa se levantar agora, seu corpo precisa de mais algumas horas até se adaptar novamente à realidade.");
        frasesTres.Add("Yael – Eu... eu não sei o que houve...");
        frasesTres.Add("Pássaro – Você acordou, é isso que houve.");
        frasesTres.Add("Yael – Eu estava em um sonho?");
        frasesTres.Add("Pássaro – Não, você estava no SOV. É uma realidade virtual, já está lá a tanto tempo que nem lembra direito que existe outra realidade né?!");
        frasesTres.Add("Yael – Eu acredito que sim... não entendo o que aconteceu, eu entrei em contato com uma máquina de refri...");
        frasesTres.Add("Pássaro – Refrigerantes! Quem diria não é mesmo? Foi o mesmo comigo e com o meu irmão, tem uma falha de cenografia dentro do SOV que te permite sair do sistema operacional através dessas máquinas. ");
        frasesTres.Add("Yael – hum... mas como?");
        frasesTres.Add("Pássaro – Meu irmão é engenheiro de software, ele criou uma falha na máquina de refrigerantes para que pudéssemos sair de lá, assim como outras pessoas que acharem a máquina.");
        frasesTres.Add("Yael – Vocês conseguiram criar uma falha no sistema e conseguiram escapar? Genial...");
        frasesTres.Add("Pássaro – Nós estamos apenas sobrevivendo.");
        frasesTres.Add("Yael – Vocês são quantos? Você e seu irmão... tem mais alguém?");
        frasesTres.Add("Pássaro – Somos apenas três, contado comigo. Nós nos viramos para sobreviver nessa cidade, evitando radioatividade e usando as máscaras como disfarce contra os drones da LIFE.");
        frasesTres.Add("Yael – Isso explica aquela máscara estranha de pássaro? A propósito, qual o seu nome?");
        frasesTres.Add("Pássaro – Aquela máscara estranha me mante vivo, exalta quem eu tenho que ser para sobreviver. Sugiro você construir a sua quando estiver pronto! E meu nome é Wing, prazer em conhecê-lo. Agora, qual o seu nome?");
        frasesTres.Add("Yael – Meu nome é Yael. Bem, vou pensar sobre isso, obrigado pela ajuda! Sem você eu já teria morrido.");
        frasesTres.Add("Pássaro – Não se preocupe, estamos precisando de mais membros. Mas se quiser ficar, vai ter que convencer os outros. Você precisa conhecer eles e apresentar a todos. Dizer quem é e o que busca. Quando estiver pronto, me chame.");
        frasesTres.Add("Yael – vou chamar, obrigado por tudo de novo.");
        
        return frasesTres;

    }


}
