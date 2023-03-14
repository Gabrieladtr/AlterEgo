using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListasDialogicas : MonoBehaviour
{

    public List<string> prologo;
    public List<string> Capitulo_1;

    public List<string> GetPrologo()
    {
        prologo = new List<string>();

        // adicionar itens em listaDialogos
        prologo.Add("Cliquei novamente para iniciar");
        prologo.Add("CyberCity... a cidade dos sonhos.");
        prologo.Add("A cidade onde você não morre, não possui doenças, pobreza, guerra ou qualquer outro problema que há na realidade. ");
        prologo.Add("Tudo isso graças ao SOV - Sistema Operacional Virtual e seu complemento, o Amotine. ");
        prologo.Add("Ambas as tecnologias da corporação LIFE.");
        prologo.Add("Dentro do SOV, na CyberCity as pessoas podem viver em paz.");
        prologo.Add("Enquanto estava a caminho de seu trabalho, como engenheiro de computação, Yael passa por uma máquina de refrigerantes e vê ela dando glitch.");
        prologo.Add("Yael decide ir verificar a máquina e acaba descobrindo uma forma de sair do SOV.");
        prologo.Add("Ao digitar um valor menor do que qualquer produto, ele acorda fora da CyberCity na cidade de Omskvi, na antiga Petrov, país que ficava localizado no leste europeu e vê toda a mata tomando conta da cidade. ");
        prologo.Add("Tinha descoberto pela primeira vez, que houve uma guerra nuclear, pois havia sido uma das primeiras cobaias a ser imputada dentro do SOV, pois havia sido um prisioneiro americo-cairano no Leste Europeu.");
        prologo.Add("Antes de desmaiar, devido seu debilitado corpo, vê um homem com uma máscara de pássaro e apaga.");
        prologo.Add("Acorda em um acampamento desconhecido e frio, começa então a buscar respostas para todas as suas dúvidas.");
    
        
        
        //msg no console
        Debug.Log("Dados adicionados em ListasDialogicas.prologo.");

        return prologo;
    }

    public List<string> GetCapitulo_1(){
        Capitulo_1 = new List<string>();
        
        Capitulo_1.Add("Pássaro – Ei ei, não precisa se levantar agora, seu corpo precisa de mais algumas horas até se adaptar novamente à realidade.");
        Capitulo_1.Add("Yael – Eu... eu não sei o que houve...");
        Capitulo_1.Add("Pássaro – Você acordou, é isso que houve.");
        Capitulo_1.Add("Yael – Eu estava em um sonho?");
        Capitulo_1.Add("Pássaro – Não, você estava no SOV. É uma realidade virtual, já está lá a tanto tempo que nem lembra direito que existe outra realidade né?!");
        Capitulo_1.Add("Yael – Eu acredito que sim... não entendo o que aconteceu, eu entrei em contato com uma máquina de refri...");
        Capitulo_1.Add("Pássaro – Refrigerantes! Quem diria não é mesmo? Foi o mesmo comigo e com o meu irmão, tem uma falha de cenografia dentro do SOV que te permite sair do sistema operacional através dessas máquinas. ");
        Capitulo_1.Add("Yael – hum... mas como?");
        Capitulo_1.Add("Pássaro – Meu irmão é engenheiro de software, ele criou uma falha na máquina de refrigerantes para que pudéssemos sair de lá, assim como outras pessoas que acharem a máquina.");
        Capitulo_1.Add("Yael – Vocês conseguiram criar uma falha no sistema e conseguiram escapar? Genial...");
        Capitulo_1.Add("Pássaro – Nós estamos apenas sobrevivendo.");
        Capitulo_1.Add("Yael – Vocês são quantos? Você e seu irmão... tem mais alguém?");
        Capitulo_1.Add("Pássaro – Somos apenas três, contado comigo. Nós nos viramos para sobreviver nessa cidade, evitando radioatividade e usando as máscaras como disfarce contra os drones da LIFE.");
        Capitulo_1.Add("Yael – Isso explica aquela máscara estranha de pássaro? A propósito, qual o seu nome?");
        Capitulo_1.Add("Pássaro – Aquela máscara estranha me mante vivo, exalta quem eu tenho que ser para sobreviver. Sugiro você construir a sua quando estiver pronto! E meu nome é Wing, prazer em conhecê-lo. Agora, qual o seu nome?");
        Capitulo_1.Add("Yael – Meu nome é Yael. Bem, vou pensar sobre isso, obrigado pela ajuda! Sem você eu já teria morrido.");
        Capitulo_1.Add("Pássaro – Não se preocupe, estamos precisando de mais membros. Mas se quiser ficar, vai ter que convencer os outros. Você precisa conhecer eles e apresentar a todos. Dizer quem é e o que busca. Quando estiver pronto, me chame.");
        Capitulo_1.Add("Yael – vou chamar, obrigado por tudo de novo.");
        
        return Capitulo_1;

    }


}
