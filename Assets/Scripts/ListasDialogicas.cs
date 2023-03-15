using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListasDialogicas : MonoBehaviour
{

    //28 capitulos

    
    public List<string> prologo;
    public List<string> Capitulo_1, Capitulo_1_1, Capitulo_1_2, Capitulo_1_3_1, Capitulo_1_3_2, Capitulo_1_4, Capitulo_2;
    public List<string> Capitulo_2_1, Capitulo_2_2, Capitulo_2_3_1, Capitulo_2_3_2, Capitulo_2_3_3, Capitulo_2_4;
    public List<string> Capitulo_2_4_1, Capitulo_3, Capitulo_3_1_1, Capitulo_3_1_2, Capitulo_3_2, Capitulo_3_3, Capitulo_3_3_1, Capitulo_3_3_2;
    public List<string> Capitulo_3_3_3;
    public List<string> Capitulo_4_A, Capitulo_4_B, Capitulo_4_C, Capitulo_4_D, Capitulo_4_E, Capitulo_5_Creditos;

    /*
    
    public List<string> GetPrologo()
    {
        prologo = new List<string>();
    
        return prologo;
    }
    
     
     */


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

    public List<string> GetCapitulo_1 (){
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

        //Proximo capitulo: 3.6	Capitulo_1_1

        return Capitulo_1;

    }

    public List<string> GetCapitulo_1_1()
    {
        Capitulo_1_1 = new List<string>();

        Capitulo_1_1.Add("Clique para continuar!");
        Capitulo_1_1.Add("CAPÍTULO 1-1 – A ORIGEM DO CÃO");

        Capitulo_1_1.Add("Prólogo do capítulo: Os dias continuavam frios, pois nevava bastante ainda. ");
        Capitulo_1_1.Add("Os ventos sopravam forte e não se ouvia nada além da neve caindo e dos ventos.");
        Capitulo_1_1.Add("Dois dias depois, Yael já se sentia forte. Achou um casaco em seu quarto e o vestiu. ");
        Capitulo_1_1.Add("Estava se sentindo confortável e quente. Abriu a porta do quarto e viu uma fogueira ao centro do acampamento. ");
        Capitulo_1_1.Add("Chamou Wing e pediu para que ele o apresentasse para os outros.");
        Capitulo_1_1.Add("Cenário: Do lado de fora do abrigo onde Yael estava, ele se reuniu com seus novos amigos. ");
        Capitulo_1_1.Add("Lá era uma espécie de acampamento em meio às florestas. Próximo dali havia um rio. ");
        Capitulo_1_1.Add("De longe se podia ver os prédios de Omskvi destruídos pela guerra. No acampamento havia barracas onde eles dormiam e se abrigavam. ");
        Capitulo_1_1.Add("Em meio a essas barracas, havia uma fogueira, onde Melinda e Jones aguardavam Wing trazer Yael para conversarem naquela noite. ");
        Capitulo_1_1.Add("Próximo dos trailers, há uma bandeira que representa a resistência Animals. Horário: 20:00.");
        Capitulo_1_1.Add("Pássaro – Pessoal, ele já se recuperou. Esse é Yael, conseguiu escapar do SOV assim como nós. Encontrei ele perto do distrito de testes da LIFE, durante uma varredura. ");
        Capitulo_1_1.Add("Yael – Olá... obrigado por me receberem, sem vocês eu teria morrido...");
        Capitulo_1_1.Add("Raposa – Nós estávamos em outra missão e quando retornamos, Wing havia trazido você para cá. Deixo bem claro que você é bem-vindo, desde que responda algumas perguntas. A propósito, somos Raposa e Coruja.");
        Capitulo_1_1.Add("Coruja – Eu não sei se devemos aceitar ele... não o conhecemos ainda, pode ser um espião do governo ou da LIFE.");
        Capitulo_1_1.Add("Raposa – Não existem mais governos... E acredite, não tem mais espiões.");
        Capitulo_1_1.Add("Coruja – Mas existe a LIFE.");
        Capitulo_1_1.Add("Raposa – A LIFE está em todos os lugares, vigiando todos. As máscaras são importantes para evitarmos sermos descobertos. ");
        Capitulo_1_1.Add("Pássaro – Com as máscaras e mantendo distância da cidade, estaremos seguros.");
        Capitulo_1_1.Add("Coruja – Até acabarem nossos recursos e termos que voltar lá.");
        Capitulo_1_1.Add("Yael –  Uhmmm, acredito que deva construir uma máscara também, certo? Eu vi um cachorro selvagem hoje mais cedo.... que tal um cão?");
        Capitulo_1_1.Add("Raposa – Desde que você esteja mascarado, pode ser qualquer animal!");
        Capitulo_1_1.Add("Pássaro – Por que você não conta sua história para a gente Yael? ");
        Capitulo_1_1.Add("Coruja – Vai ser bom saber a história desse espião haha.");
        Capitulo_1_1.Add("Raposa – Silêncio, por favor nos conte sua história Yael.");
        Capitulo_1_1.Add("Yael – Bem, para começo de conversa eu não sou cidadão petrove. Nasci em Cairohill, na América. Todos sabem que Cairohill é um país pequeno na américa do norte, então não havia muitas oportunidades por lá. Eu estudava engenharia de software e consegui um intercâmbio para o leste europeu, aqui no país de vocês, Petrov");
        Capitulo_1_1.Add("Coruja – (desconfiado) - Sério que você não é um espião?");
        Capitulo_1_1.Add("Yael – Não sou. Fui confundido com vândalos na capital, há alguns anos. Fui preso em Krestymov. Para sair da pena, fui cobaia da LIFE para o Amotine e SOV. ");
        Capitulo_1_1.Add("Raposa – (surpresa) – Você foi um dos primeiros a entrar no SOV?");
        Capitulo_1_1.Add("Yael – (Cabisbaixo) – Sim. Eu fui cobaia, acabei que segui minha vida online. Não sabia nada que estava acontecendo aqui fora. Nem da guerra, nem das bombas, nada.");
        Capitulo_1_1.Add("Pássaro – (Triste e convencido) - Sorte sua. Eu lutei na guerra. Vi coisas que jamais gostariam de ver. Vi cidades sendo explodidas, vi crianças perdidas e sem rumo... Vi tudo o que nunca jamais deveria acontecer.");
        Capitulo_1_1.Add("Coruja – Eu também não vi a guerra. Eu tinha uma vida normal dentro do SOV, mas quando saí, pude ver que nada daquilo era real. Era só uma distração.");
        Capitulo_1_1.Add("Raposa – Linda.");
        Capitulo_1_1.Add("Yael – O quê?");
        Capitulo_1_1.Add("Raposa – Linda. Minha irmã. Ela foi uma das causas dessa guerra. Foi ela quem destruiu tudo que vocês conheciam.");
        Capitulo_1_1.Add("Pássaro – Nunca vou entender. Como uma mulher pode ajudar a causar uma guerra?");
        Capitulo_1_1.Add("Raposa – Não se engane, ela não é apenas uma mulher. É uma espiã enviada pela LIFE... - ");
        Capitulo_1_1.Add("Coruja – Nós a encontramos uma vez antes.... Foi ela quem nos atacou dentro do SOV, não é mesmo Wing?");
        Capitulo_1_1.Add("Pássaro – Sim, ela estava atrás de nós porque sabia que queríamos sair de lá.");
        Capitulo_1_1.Add("Yael – Se ela estava atrás de vocês, então ela provavelmente ainda está localizando a gente. ");
        Capitulo_1_1.Add("Raposa – Wing, será que algum drone chegou a ver o rosto de Yael? ");
        Capitulo_1_1.Add("Pássaro – Não que eu saiba..., mas talvez alguma câmera de segurança.");
        Capitulo_1_1.Add("Raposa – Precisamos urgente construir a máscara do Yael. Próximo do rio, descendo nossa base há um material chamado Carlya, maleável e leve você consegue conseguir uma máscara formidável.");
        Capitulo_1_1.Add("Coruja – Eu encontrei algumas tintas em uma maleta abandonada próximo da estrada 886. Você pode usá-las.");
        Capitulo_1_1.Add("Yael – Irei fazer isso agora.");
        Capitulo_1_1.Add("Pássaro – Vou com ele.");
        Capitulo_1_1.Add("Raposa – Ótimo.");

        //Proximo capitulo: 3.6	Capitulo_1_2

        return Capitulo_1_1;
    }

    

    
    public List<string> GetCapitulo_1_2()
    {
        Capitulo_1_2 = new List<string>();

        Capitulo_1_2.Add("CAPÍTULO 1-2 – A DECISÃO DO CÃO");

        Capitulo_1_2.Add("Yael – Então essa é a Carlya, realmente um ótimo material para uma máscara. Eu vi um cão mais cedo. Sempre me imaginei sendo quem eu realmente quis ser, meu alter ego. Penso em ser como um cão, sem dono, que apenas sobrevive. Muitas vezes expressado nas atitudes do dia a dia, hoje posso comtemplar o que é ser o que sempre fui, de forma oculta. Hoje, através dessa máscara, posso ser eu de verdade. Além de poder me manter a salvo, dos drones da LIFE.");
        Capitulo_1_2.Add("Pássaro – Todos nós possuímos lados e até mesmo personalidades diferentes dentro de nós, muitas vezes ocultas. A máscara nos torna reais, nos traz para essa verdade. Principalmente por termos passado tanto tempo com vendas nos olhos e não percebemos o que a LIFE fez com tudo e todos, inclusive eu. Você é um dos poucos cidadãos cairence que conheci que não lutei contra. Vocês são boas pessoas. O que Petrov pregava era diferente.");
        Capitulo_1_2.Add("Yael – Eu sinto muito pelo que passou. Não temos culpa se um maluco causou tudo isso. Somos apenas seres humanos que estamos sobrevivendo, em meio à uma era desértica e caótica. Mas me sinto triste mesmo assim, por termos tido guerras entre nossos povos.");
        Capitulo_1_2.Add("Pássaro – Você sabe do que fala. E isso me agrada. Eu também sinto muito pelo que houve. Gostaria de voltar no tempo e poder evitar tantas coisas. Mas sinto que ainda posso ajudar a reverter esse caos. Eu tenho tido ideias de resistência contra a LIFE, tenho perdido noites de sono pensando em como poderia derrotar o criador, a Linda. Mas sei que sozinho não consigo. A nossa resistência, a Animals foi iniciada pelo pai da Melinda, Asimovitsky. Mas fomos nós que demos vida à resistência. Ele só tinha ideias, mas nós estamos aqui, sobrevivendo e fazendo acontecer. Você pode pedir para ela explicar quem foi ele depois.");
        Capitulo_1_2.Add("Yael – Vocês são fortes, muito fortes. Estamos vivendo um inverno rigoroso e vocês continuam lutando contra tudo isso, e conseguem. Lutar contra a LIFE parece ser uma tarefa difícil. Mas sei que é possível.");
        Capitulo_1_2.Add("Pássaro – Conseguimos sobreviver, mas não sei por quanto tempo. Estou preocupado com Melinda e com Jones, ele tem precisado de medicamento e Melinda parece estar ficando paranoica com a ideia de que fomos vencidos.");
        Capitulo_1_2.Add("Yael – O que quer dizer com isso?");
        Capitulo_1_2.Add("Pássaro – Precisamos de ajuda, lutar para valer contra a LIFE, para finalmente vencermos. Garantir nossa segurança, salvar os outros do SOV. E pensar que eles não fazem a mínima ideia de que estão sendo escravizados e em breve morrerão.");
        Capitulo_1_2.Add("Yael – Como assim morrerão? Não sabia que as pessoas conectadas corriam risco de vida...");
        Capitulo_1_2.Add("Pássaro – Jones me contou que as pessoas têm sumido do SOV, você deve ter notado isso enquanto estava lá.");
        Capitulo_1_2.Add("Yael – Sim, notei sim...");
        Capitulo_1_2.Add("Pássaro – Os Amotines estão começando a descarregar. Isso significa que o que supre todas as necessidades das pessoas deixará de existir. Por isso muitos têm desaparecido do SOV, porque foram desativados tanto online como na realidade, porque morreram.");
        Capitulo_1_2.Add("Yael – (triste) - Tudo faz sentido agora, tive colegas de trabalho da época de Krestymov que desapareceram antes de eu acordar fora do SOV. Então significa que eles se foram... e eu nem pude me despedir...");
        Capitulo_1_2.Add("Pássaro – Tudo está um caos. E confesso, sem ajuda não vamos conseguir salvar ninguém. Se entrarmos novamente no SOV Linda virá nos matar e se ficarmos de bobeira em Omskvi, os drones podem nos entregar, mesmo com essas máscaras.");
        Capitulo_1_2.Add("Yael – O que quer que eu faça?");
        Capitulo_1_2.Add("Pássaro – Quero que se junte à gente. Quero que faça parte dos Animals. Uma máscara de animal pode te ajudar a sobreviver, mas suas atitudes dizem o que o seu alter ego realmente é. Você tem que escolher, quer fazer parte dessa luta ou quer enfrentar esse mundo sozinho? Você decide, você é quem faz as suas escolhas. Lembre-se, todas as suas escolhas no SOV eram irrelevantes, mas aqui... aqui elas possuem consequências. Escolha com sabedoria.");
        Capitulo_1_2.Add("Decisão:");

        //Escolha 1: Fazer parte dos Animals, com o Alter Ego “Cão”.
        //Escolha 2: Não fazer parte dos Animals, decidir apenas seguir seu caminho em busca dos cacos de vidro que um dia foram a vidraça de sua vida. Lutar contra os fantasmas do passado e lidar com o mundo caótico que se vive. Viver com o peso nas suas costas que é saber, que você deixou de lado salvar a humanidade por querer descobrir quem é você e qual é seu papel nesse mundo, sozinho.


        return Capitulo_1_2;
    }

    public List<string> GetCapitulo_1_3_1()
    {
        Capitulo_1_3_1 = new List<string>();

        Capitulo_1_3_1.Add("CAPÍTULO 1-3-1 – O CÃO SE DECIDIU – ESCOLHA 1");

        Capitulo_1_3_1.Add("Cão (Yael) – Eu não sei o que pode me aguardar lá fora. Mas sei que posso contar com vocês. Vocês me salvaram uma vez e sinto que devo retribuir o favor que me fizeram. Eu também desejo descobrir quem é o criador da LIFE e quem mandou matou meu amigo em , quando eu fiquei preso em Krestymov.");
        Capitulo_1_3_1.Add("Pássaro – Ótimo! Com você do nosso lado, poderemos enfrentar a LIFE. Agora que decidiu ficar, devo apresentar o nome de cada um dos outros membros. O Coruja é meu irmão, Jones. E a Raposa é Melinda. Foi ela quem salvou a minha vida e a do meu irmão, quando conseguimos sair do SOV.");
        Capitulo_1_3_1.Add("Cão (Yael) – É muito bom saber os nomes deles... Eles estavam com aquelas máscaras, gostaria de perguntar antes, mas agora sei.");
        Capitulo_1_3_1.Add("Wing – Em breve quero mostrar meu plano de ataque à LIFE, ajudará muito a sua força. Agora, vamos voltar para o acampamento.");
        Capitulo_1_3_1.Add("Cão (Yael) – Vamos voltar.");

        //Proximo capitulo: 3.6	CAPÍTULO 1-4 

        return Capitulo_1_3_1;
    }

    public List<string> GetCapitulo_1_3_2()
    {
        //Final 1
        Capitulo_1_3_2 = new List<string>();

        Capitulo_1_3_2.Add("CAPÍTULO 1-3-2 'FINAL 1' – O CÃO SE DECIDIU – ESCOLHA 2 (NÃO FAZER PARTE DOS ANIMALS)");

        Capitulo_1_3_2.Add("Wing - Ontem eu vi um homem único, com uma personalidade maravilhosa. Cada detalhe era único, hoje eu o vi. Mas hoje, é apenas uma cópia barata de homens. Você é esse homem Yael. Você não serve para ser um herói. ");
        Capitulo_1_3_2.Add("Yael – Sinto muito Wing, mas sei que devo seguir meu caminho sozinho. Boa sorte com seus planos de salvar a humanidade.");
        Capitulo_1_3_2.Add("Wing – Adeus.");
        Capitulo_1_3_2.Add("Yael – Adeus.");


        return Capitulo_1_3_2;
    }

    public List<string> GetCapitulo_1_4()
    {
        Capitulo_1_4 = new List<string>();

        Capitulo_1_4.Add("CAPÍTULO 1-4 – DE VOLTA AO ACAMPAMENTO – ESCOLHA 1");

        Capitulo_1_4.Add("Wing - Pessoal, Yael já possui a máscara dele. E ele decidiu ficar conosco e lutar contra a LIFE. Ele comentou que quer retribuir o favor que fizemos a ele, por salvá-lo. ");
        Capitulo_1_4.Add("Coruja (Jones) – Bem-vindo Yael, você é um de nós agora.");
        Capitulo_1_4.Add("Raposa (Melinda) – Bem-vindo Yael, sinta-se em casa. Você nos ajudará em muitas coisas, pode ficar com aquele trailer para você. A partir de agora aqui será sua casa. Lutaremos juntos nessa guerra contra a LIFE.");
        Capitulo_1_4.Add("Cão (Yael) – Obrigado, mais uma vez... Podem me chamar de Cão. Será meu alter ego, minha nova forma de ser nesse mundo. Minha nova versão.");
        Capitulo_1_4.Add("Wing (Pássaro) – Certo, Cão. Já está escurecendo, e está nevando. Acho bom irmos descansar, amanhã quero apresentar meu plano de ataque à LIFE. Tenho certeza de que irão gostar!");
        Capitulo_1_4.Add("Coruja (Jones) – Ótimo Wing, estaremos juntos nessa!");
        Capitulo_1_4.Add("Raposa (Melinda) – Podem ir rapazes, mas antes preciso conversar com o Cão.");
        Capitulo_1_4.Add("Wing (Pássaro) – Vejo vocês amanhã!");
        Capitulo_1_4.Add("Coruja (Jones) – Até!");
        Capitulo_1_4.Add("Cão (Yael) – Você tem algo pra me dizer?!");
        Capitulo_1_4.Add("Raposa (Melinda) – Sim, tenho. Tenho ficada paranoica com a ideia de que a Linda está atrás de nós, principalmente eu. ");
        Capitulo_1_4.Add("Cão (Yael) – Olha, tenho certeza de que Wing irá nos ajudar com o plano dele. Tenho certeza de que iremos conseguir vencer esse momento difícil. ");
        Capitulo_1_4.Add("Raposa (Melinda) – Eu fico mais tranquila em ouvir isso.");
        Capitulo_1_4.Add("Cão (Yael) – Eu estava curioso, você é irmã da Linda? Ouvi dizer que ela é uma espécie de robô/humana. Então, você é da mesma espécie que ela?");
        Capitulo_1_4.Add("Raposa (Melinda) – Eu sou uma Androtine (Android + Amotine), gerada pela LIFE para criar o caos no mundo, gerando guerras. O Amotine é a tecnologia da LIFE, que mistura elementos biológicos com tecnologia de ponta. Eu sou uma espécie de android que funciona a base do amotine. Apenas eu e Linda fazemos parte dessa espécie.");
        Capitulo_1_4.Add("Cão (Yael) – Isso explica o porquê de ela estar caçando todos vocês");
        Capitulo_1_4.Add("Raposa (Melinda) – Mas, meu criador, Asimovitsky, implantou um software chamado EmotionSoftware.exe na minha mente, onde me torna praticamente uma humana, pois a partir disso emulo emoções humanas. Eu sou o contrário da Linda, por isso não causei mal a ninguém e vivo fugindo da LIFE. ");
        Capitulo_1_4.Add("Raposa (Melinda) – Esse software, chamado EmotionSoftware.exe foi implantando em mim, para começar uma revolução contra a LIFE. Asimovitsky era um dos cientistas de Malev, o criador da LIFE. Eles eram amigos, mas Malev começou a ficar louco, com ideias de dominação mundial. ");
        Capitulo_1_4.Add("Raposa (Melinda) – Asimovitsky não concordava com muitas ideias do Malev, então começou a criar uma espécie de resistência contra a própria LIFE, mas em segredo. Meu corpo havia sido descartado pela LIFE, por ser emotiva demais naqueles testes, enquanto Linda havia passado em todos os testes de neutralidade.");
        Capitulo_1_4.Add("Raposa (Melinda) – Depois de eu ter sido descartada pela LIFE, Asimovitsky me resgatou, me reativou e me enviou para seu apartamento, onde eu encontraria tudo para conseguir sobreviver. ");
        Capitulo_1_4.Add("Raposa (Melinda) – Após eu fugir da LIFE, o criador matou Asimovitsky, dizendo que ele o traiu. Desde então eu aprendi a viver sozinha. Um tempo depois, construí esse acampamento e encontrei Wing e Jones a beira da morte um tempo atrás. Após salvar a vida deles, juntos, nós tornamos realidade o sonho de Asimovitsky, a resistência Animals. Uma resistência que luta contra a LIFE e quer restaurar o que essa terra já foi um dia: um bom lugar para se viver.");
        Capitulo_1_4.Add("Cão (Yael) – Então, isso explica muitas coisas...");
        Capitulo_1_4.Add("Raposa (Melinda) – Mas sozinhos não conseguiremos vencer a LIFE, vamos precisar de ajuda para vencer essa luta. Nós confiamos em você Yael, talvez esse seja um sacrifício e talvez não sairemos vivos dessa luta. Mas sei que devemos salvar os humanos, eles não merecem viver conectados para sempre em uma realidade que não existe. ");
        Capitulo_1_4.Add("Cão (Yael): Vamos vencer essa luta, não se preocupe. Sei que não é fácil perder um pai, eu perdi toda a minha família... A humanidade será restaurada. Um dia teremos um mundo bom para todos novamente, sem a LIFE.");
        Capitulo_1_4.Add("Raposa (Melinda) – Fico muito feliz em ouvir essas palavras. Sinto que você está do meu lado e da nossa causa. Bem... está tarde. Acho que seria bom todos nós irmos dormir, amanhã será um dia de trabalho e tanto. Obrigada por tudo Yael, quer dizer, Cão.");
        Capitulo_1_4.Add("Cão (Yael) [agradecido].");

        //CAPÍTULO 2

        return Capitulo_1_4;
    }

    public List<string> GetCapitulo_2()
    {
        Capitulo_2 = new List<string>();

        Capitulo_2.Add("CAPÍTULO 2 – O PLANO DE ATAQUE À LIFE – ESCOLHA 1");

        Capitulo_2.Add("Wing (Pássaro) – Enfim, estamos aqui. Diante do nosso plano de ataque à LIFE. Vamos nos vingar pela guerra, pela destruição. Vamos nos vingar por tudo o que houve com nossa terra. O Criador da LIFE e quem estiver no caminho vai pagar caro.");
        Capitulo_2.Add("Wing (Pássaro) – O meu plano é o seguinte, vamos até o distrito onde achei Yael. Lá vamos encontrar o equipamento necessário para entrar no Sistema Operacional Virtual, o SOV. ");
        Capitulo_2.Add("Wing (Pássaro) – Quando entrarmos no SOV, vamos pegar o transporte até a LIFE. Vamos até o edifício deles, entraremos no edifício e encontraremos o criador. Quando encontrarmos ele, vamos forçá-lo a restaurar as células dos Amotines ou o que der para fazer. ");
        Capitulo_2.Add("Cão (Yael) – Entrar lá não deve ser difícil, o problema é que não temos armas para nos defender. É suicídio fazer isso.");
        Capitulo_2.Add("Coruja (Jones) – Vamos precisar de armas.");
        Capitulo_2.Add("Wing (Pássaro) – Eu fui do exército, não há fornecimento de armas atualmente para nenhum local. Nada.");
        Capitulo_2.Add("Raposa (Melinda) – E que tal os drones? ");
        Capitulo_2.Add("Cão (Yael) – É verdade! Os drones!");
        Capitulo_2.Add("Coruja (Jones) – Podemos usar os drones como armas. Eles possuem metralhadoras acopladas em sua fuselagem. Mas... como podemos usar os drones ao nosso favor?");
        Capitulo_2.Add("Raposa (Melinda) – Simples, hackeamos. Se não conseguirmos hackear um simples drone, então devemos desistir por aqui. Mas sei que vamos conseguir!");
        Capitulo_2.Add("Wing (Pássaro) – Temos dois engenheiros de software que viveram dentro do SOV. Vamos conseguir hackear esses drones sim. Não é, homens?");
        Capitulo_2.Add("Cão (Yael) – Vou fazer o meu melhor para a resistência.");
        Capitulo_2.Add("Coruja (Jones) – Vamos hackear esses drones!");
        Capitulo_2.Add("Wing (Pássaro) – Temos uma longa caminhada até o distrito de testes da LIFE. Vamos nos organizar e partimos daqui a vinte minutos.");

        return Capitulo_2;
    }

    public List<string> GetCapitulo_2_1()
    {
        Capitulo_2_1 = new List<string>();

        Capitulo_2_1.Add("CAPÍTULO 2.1 – DISTRITO DE TESTES DA LIFE – ESCOLHA 1");

        Capitulo_2_1.Add("Coruja (Jones) – Estamos aqui. Distrito de testes da LIFE. Eu tenho um apartamento dentro do SOV. Vou configurar para o sistema nos enviar para lá quando ficarmos online.");
        Capitulo_2_1.Add("Wing (Pássaro) – Foi aqui onde achei Yael. ");
        Capitulo_2_1.Add("Cão (Yael) – Eu estava tão doente que nem lembrava desse lugar.");
        Capitulo_2_1.Add("Wing (Pássaro) – Nós devemos nos conectar ao SOV através dos amotines, lembrem-se disso. No momento que nos conectarmos ao SOV, a Linda ficará sabendo de nós. Através daquele software de monitoramento que eu nem sei o nome!");
        Capitulo_2_1.Add("Raposa (Melinda) – Vamos ter que correr para evitarmos um confronto direto. ");
        Capitulo_2_1.Add("Cão (Yael) – Nós precisamos hackear alguns drones antes de entrarmos no SOV.");
        Capitulo_2_1.Add("Coruja (Jones) – Se quisermos armas dentro do SOV, vamos precisar hackear os drones e conectá-los ao sistema. O que acha Yael?");
        Capitulo_2_1.Add("Decisão:");

        //Escolha 1.1 – Hackear os drones e conectá-los ao SOV (mais segurança no SOV) = puzzle
        //Escolha 1.2 – Não hackear os drones e não conectá-los ao SOV (menos segurança no SOV)




        return Capitulo_2_1;
    }


    public List<string> GetCapitulo_2_2()
    {
        Capitulo_2_2 = new List<string>();
        //Escolha 1.1 – Hackear os drones e conectá-los ao SOV (mais segurança no SOV) = puzzle

        Capitulo_2_2.Add("O valor do segundo é a quantidade de prédios no ambiente");
        Capitulo_2_2.Add("O valor do terceiro é o dobro do segundo");
        Capitulo_2_2.Add("O valor terceiro menos o segundo, é o primeiro");
        Capitulo_2_2.Add("O quarto é o primeiro mais o primeiro");

        //Consequência 1: Caso o código seja inserido corretamente: os drones foram hackeados e conseguem ajudar dentro do SOV.
        //Consequência 2: Caso o código seja inserido incorretamente: Os drones não foram hackeados e os drones foram alertados durante o hack. Melinda morre devido a um tiroteio.
        //Consequência 3: O puzzle foi pulado. Não foi hackeado os drones e não foram conectados ao SOV (menos segurança no SOV). Wing ou Jones podem morrer 

        return Capitulo_2_2;
    }

    public List<string> GetCapitulo_2_3_1()
    {
        Capitulo_2_3_1 = new List<string>();

        //Cenário: Dentro do Distrito de Testes.

        Capitulo_2_3_1.Add("Coruja (Jones) – Boa Yael! Quero dizer, agora você é um de nós! Então devemos te chamar de Cão. Boa Cão! Você conseguiu hackear o sistema dos drones, agora eles estão programados para nos ajudar em caso de conflito!");
        Capitulo_2_3_1.Add("Wing (Pássaro) – Ainda bem que Yael conseguiu hackeá-los, nem imagino o que poderia acontecer se ele errasse o código.");
        Capitulo_2_3_1.Add("Cão (Yael) – (sentindo-se agradecido) – Obrigado Animals!");
        Capitulo_2_3_1.Add("Raposa (Melinda) – O que importa é que vamos conseguir acessar o SOV. ");
        Capitulo_2_3_1.Add("Raposa (Melinda) – O SOV será um universo novo pra mim. Nunca estive lá, mas minha irmã, Linda, provavelmente estará nos esperando lá. Mal posso esperar pelo o que vamos encontrar no caminho.");
        Capitulo_2_3_1.Add("Cão (Yael) – (confiante): Vamos conseguir salvar toda a humanidade. Tudo será restaurado. Mas nós precisamos ser fortes. Vamos lutar pra valer lá dentro!");
        Capitulo_2_3_1.Add("Wing (Pássaro) – Vamos conseguir!");
        Capitulo_2_3_1.Add("Coruja (Jones) – Vai dar tudo certo!");
        Capitulo_2_3_1.Add("Raposa (Melinda) – Eu confio em vocês rapazes! Vamos conseguir sim!");
        Capitulo_2_3_1.Add("Wing (Pássaro) – Coruja, o que devemos fazer para nos conectarmos dentro do SOV e irmos direto para seu apartamento lá na CyberCity?");
        Capitulo_2_3_1.Add("Coruja (Jones) – Enquanto a gente conversava eu já configurava tudo. O que vamos fazer é conectar os alimentadores em nós. Nós só precisamos segurar os Amotines, e o SOV será inicializado automaticamente. Não se preocupem, vamos todos para o mesmo lugar. Meu apartamento é seguro.");


        //Cenário: Logotipo do SOV by LIFE iniciando
        Capitulo_2_3_1.Add("L.I.A. - Inicializando SOV... Bem-vindo ao Sistema Operacional Virtual! Desenvolvido pela corporação LIFE. ");
        Capitulo_2_3_1.Add("L.I.A. - Em breve você estará em um mundo inteiramente virtual. ");
        Capitulo_2_3_1.Add("L.I.A. - A nossa cidade no nosso mundo se chama CyberCity.");
        Capitulo_2_3_1.Add("L.I.A. - Haha... Eu nem me apresentei. Meu nome é L.I.A., Lua, Inteligência Artificial da LIFE. Mas pode me chamar só de LIA, ok? 😊");
        Capitulo_2_3_1.Add("L.I.A. - A propósito... você conhece a nossa história? Que tal nos conhecer melhor enquanto te inserimos em nosso mundo?");
        Capitulo_2_3_1.Add("L.I.A. - O SOV foi criado para que Petrov sobrevivesse à guerra nuclear.  Nós criamos drones para cuidarem das pessoas conectadas aos amotines, dentro dos abrigos nucleares. Mas... acontece que não há registros de vida humana, além desses fora do SOV ☹");
        Capitulo_2_3_1.Add("L.I.A. - Então o SOV foi um sucesso, não é? Isso me deixa feliz. ");
        Capitulo_2_3_1.Add("L.I.A. - Continuando nossa história");
        Capitulo_2_3_1.Add("L.I.A. - Durante a década de 1980 Malev, o criador, havia crescido em uma era de conflitos políticos, onde via durante todos os dias a dor e o sofrimento das pessoas de Petrov. Toda essa dor era sentida pelo mundo todo. ");
        Capitulo_2_3_1.Add("L.I.A. - Petrov estava enfrentando uma guerra contra seus inimigos do Leste Europeu e não possuía nenhum tipo de apoio dos americanos ou do oeste europeu, pois todos tinham medo de causar uma guerra ainda maior.");
        Capitulo_2_3_1.Add("L.I.A. - Ele viu toda a sua cidade, seus sonhos, amigos e familiares sendo destruídos e mortos, e ninguém podia ajudar.");
        Capitulo_2_3_1.Add("L.I.A. - Então, com suas habilidades em tecnologia, construiu a primeira versão do SOV. Onde poderia ter um ambiente online, contendo as almas das pessoas de quem gostava em segurança.");
        Capitulo_2_3_1.Add("L.I.A. - Naquele tempo, um dos poucos abrigos subterrâneos para cientistas estava construindo armas para conseguir se defender de seus inimigos, o Sci-Petrov");
        Capitulo_2_3_1.Add("L.I.A. - Ele, apenas com seu computador foi até o abrigo e ofereceu ajuda contra os inimigos.");
        Capitulo_2_3_1.Add("L.I.A. - Malev foi aceito, por ter em mãos o que poderia ser uma nova forma de sobreviver aos ataques inimigos.");
        Capitulo_2_3_1.Add("L.I.A. - Dentro do Sci-Petrov, ele conheceu o Asimovitsky, um cientista brilhante onde se tornaram grandes amigos, por compartilharem de crenças parecidas.");
        Capitulo_2_3_1.Add("L.I.A. - Malev tinha um ódio interno, por conta de seus inimigos destruírem o seu país e um ódio ainda maior dos outros países que permitiram tudo acontecer.");
        Capitulo_2_3_1.Add("L.I.A. - Malev colocou a primeira versão do SOV para funcionar e os cientistas perceberam que ele havia construído o que poderia ser uma nova forma de se viver.");
        Capitulo_2_3_1.Add("L.I.A. - Asimovitsky, percebeu que o SOV não era suficiente para conseguirem sobreviverem desenvolveu a primeira versão do Amotine. ");
        Capitulo_2_3_1.Add("L.I.A. – É graças ao amotine que é possível que as pessoas sejam conectadas ao SOV. Ele consegue nutrir todas as necessidades do corpo humano e ao mesmo tempo, plugá-lo em um ambiente 100% virtual.");
        Capitulo_2_3_1.Add("L.I.A. – O finado Asimovitsky foi um grande gênio. Agradecemos a ele por toda a contribuição!");
        Capitulo_2_3_1.Add("L.I.A. - ...");
        Capitulo_2_3_1.Add("L.I.A. - Malev e Asimovitsky, juntos criaram a LIFE. Todos os cientistas da Sci-Petrov concordaram a passarem a fazer parte da LIFE e juntos começaram a criar servidores para conseguirem armazenar os sobreviventes de Petrov, para garantirem sua segurança. ");
        Capitulo_2_3_1.Add("L.I.A. - Após o sistema da LIFE estar pronto, começaram a pegar prisioneiros na prisão de  Krestymov para testar seus sistemas. ");
        Capitulo_2_3_1.Add("L.I.A. - Logo após os cientistas verem o sucesso do SOV, muitos foram enviados para construírem o que seria o novo lar das pessoas: A CyberCity.");
        Capitulo_2_3_1.Add("L.I.A. - Malev passou a ser chamado de Criador, por ter salvado todas as pessoas de serem vítimas dos conflitos políticos e ter criado todo um sistema para isso.");
        Capitulo_2_3_1.Add("L.I.A. - Embora o Criador tivesse feito algo bom, seu coração estava corrompido pela vingança contra seus inimigos.");
        Capitulo_2_3_1.Add("L.I.A. - Após alguns anos, em seu cargo bem estabelecido, sendo o chefe da LIFE, ordenou que os cientistas que ainda estavam off-line começassem um projeto novo, para aniquilar toda a terra e trouxessem todos para o SOV, dessa forma todos os que não quiseram ajudar na guerra saberiam o que o povo petrove passou durante os anos de conflito e passariam a viver dentro do SOV. Seria uma nova forma de haver paz no mundo, sem fome, nem guerra, nem mortes...");
        Capitulo_2_3_1.Add("L.I.A. – ...");
        Capitulo_2_3_1.Add("L.I.A. – Espero que você tenha gostado da nossa história. ");
        Capitulo_2_3_1.Add("L.I.A. – Em breve nos encontraremos de novo! Até logo 😊");

        //Cenário: Lobby do SOV – Apartamento de Jones.

        Capitulo_2_3_1.Add("Cão (Yael) – Uau, a LIA também apareceu para vocês? Agora entendi tudo sobre a história da LIFE.");
        Capitulo_2_3_1.Add("Raposa (Melinda) – Ela também apareceu pra mim. Estou feliz em ouvir um pouco sobre o meu criador, Asimovitsky.");
        Capitulo_2_3_1.Add("Wing (Pássaro) – Bem, pelo menos a LIFE agradeceu ele por ter contribuído.");
        Capitulo_2_3_1.Add("Raposa (Melinda) – Malev matou meu pai! Essa é a verdade. ");
        Capitulo_2_3_1.Add("Coruja (Jones) – (Surpreso) - Não pode ser verdade! Ele deve ter ocultado de todos.");
        Capitulo_2_3_1.Add("Raposa (Melinda) – (cabisbaixa) - Depois que Asimovitsky me reativou, no seu leito de morte, após Malev ter o esfaqueado, ele me deu um livro. Esse livro é um diário de toda a sua vida.");
        Capitulo_2_3_1.Add("Cão (Yael) – Então... nesse diário possui toda a vida de Asimovitsky comentada?");
        Capitulo_2_3_1.Add("Raposa (Melinda) – Sim. A vida inteira dele. Nesse diário tem todos os detalhes do que a LIFE se tornou.");
        Capitulo_2_3_1.Add("Raposa (Melinda) – Eu vou deixá-lo com você Yael. Você quer e precisa saber da verdade.");
        Capitulo_2_3_1.Add("Cão (Yael) – Obrigado Melinda, digo... Raposa.");
        Capitulo_2_3_1.Add("Raposa (Melinda) – (Feliz).");
        Capitulo_2_3_1.Add("Coruja (Jones) – Bem, se queremos invadir a LIFE e derrotar a Linda e o criador, digo... Malev, vamos precisar pegar o transporte público para o edifício dele.");

        //Cenário: Mapa da CyberCity.
        Capitulo_2_3_1.Add("Cão (Yael) – Essa é a CyberCity. Que pena que não viemos para nos divertir, há muitos locais interessantes que gostava de ir...");
        Capitulo_2_3_1.Add("Coruja (Jones) – Não se engane, a LIFE te dá a faca e o queijo, mas você está preso dentro de uma jaula. Sem liberdade. O mundo já é habitável lá fora, mas Malev quer continuar dominando o mundo. ");
        Capitulo_2_3_1.Add("Wing (Pássaro) – Eu concordo com o Coruja. Sem contar que os amotines estão desligando. Isso significa que devemos reativar as células dos amotines antes que seja tarde.");
        Capitulo_2_3_1.Add("Raposa (Melinda) – Para onde vamos Coruja? ");
        Capitulo_2_3_1.Add("Coruja (Jones) – Vamos pegar o transporte na Estação 14-7.");
        Capitulo_2_3_1.Add("Coruja (Jones) – Depois vamos pegar o trem para a Estação 25-6");
        Capitulo_2_3_1.Add("Coruja (Jones) – De lá vamos descer na frente da LIFE.");
        Capitulo_2_3_1.Add("Raposa (Melinda) – Então vamos!");

        return Capitulo_2_3_1;
    }

    public List<string> GetCapitulo_2_3_2()
    {
        Capitulo_2_3_2 = new List<string>();

        Capitulo_2_3_2.Add("CAPÍTULO 2.3.2 – INVADINDO O SOV – (ESCOLHA 1.1) – CONSEQUÊNCIA 2");

        //Cenário: Dentro do Distrito de Testes. Após um tiroteio Melinda é alvejada, morre lutando contra a LIFE.

        Capitulo_2_3_2.Add("Wing (Pássaro) (Surpreso) – Nãoooooo!!!! Raposaaaa!!!!");
        Capitulo_2_3_2.Add("Coruja (Jones) – Os drones atiraram na Raposa... Como você pôde deixar isso acontecer Cão?? Melinda!!!");
        Capitulo_2_3_2.Add("Raposa (Melinda) – (Suspiro melancólico) - ...");
        Capitulo_2_3_2.Add("Cão (Yael) (assustado) – Eu... acho que errei o código... Cuidado! Os drones estão atirando ainda! Se abaixem!");
        Capitulo_2_3_2.Add("Wing (Pássaro) – (Se abaixa) -...");
        Capitulo_2_3_2.Add("Coruja (Jones) (assustado) – Os drones escaparam, quando eles detectam perigo eles fogem ou atiram...");
        Capitulo_2_3_2.Add("Wing (Pássaro) (desesperado)– Melinda? Consegue me ouvir?...");
        Capitulo_2_3_2.Add("Raposa (Melinda) – (Suspiro melancólico) – Eu acho que não vou conseguir continuar com vocês rapazes... Vocês devem ser fortes – cuspindo sangue -, vinguem minha morte... Yael, pegue esse livro... Você busca respostas, meu pai Asimovitsky me deu no seu leito de morte... quero que você o guarde... Adeus... Animals...");
        Capitulo_2_3_2.Add("Coruja (Jones) (escorrendo algumas lágrimas através da máscara) – Adeus raposinha... Sentirei sua falta...");
        Capitulo_2_3_2.Add("Coruja (Jones) (silêncio) - ...");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Adeus Melinda, descanse em paz... Traremos vitória para os Animals...");
        Capitulo_2_3_2.Add("Wing (Pássaro) - (silêncio) – ...");
        Capitulo_2_3_2.Add("Cão (Yael) –(silêncio) – Eu aceito o livro... vingarei sua morte Melinda, Adeus... ");
        Capitulo_2_3_2.Add("Cão (Yael) – ...");
        Capitulo_2_3_2.Add("Wing (Pássaro) – ...");
        Capitulo_2_3_2.Add("Coruja (Jones) – ...");
        Capitulo_2_3_2.Add("Cão (Yael) – Eu sinto muito pela perda pessoal. Eu juro, foi um acidente...");
        Capitulo_2_3_2.Add("Wing (Pássaro) - (Raivoso)– QUANDO EU TE TROUXE PARA OS ANIMALS, EU ACHAVA QUE VOCÊ IRIA NOS AJUDAR E NÃO NOS MATAR, CÃO. ");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Acabamos de perder quem mais nos importávamos. Olha o que você fez!");
        Capitulo_2_3_2.Add("Cão (Yael) – (Assustado) – FOI UM ACIDENTE!! POR FAVOR, NÃO ME TIREM DOS ANIMALS! Eu não sei o que pode acontecer comigo sem vocês...");
        Capitulo_2_3_2.Add("Wing (Pássaro) – A vida pra você é fácil não é?...");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Deixa-me contar uma história. O nome do meu pelotão era os Asas de Águia.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Eu e meu irmão, Jones nos separamos durante o início da guerra, eu, como um militar fui servir na guerra de Petrov contra os inimigos americo-cairano. Porém meu irmão, Jones, engenheiro de software foi obrigado a ser conectado ao SOV junto com diversos outros cidadãos da cidade de Omskvi através de um programa de sobrevivência da LIFE.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Quando a guerra acabou, eu, como líder e um alguns dos poucos sobreviventes de um pelotão chamado Asas de águia, pôde finalmente ir atrás da nossa família e descobrir o que houve.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – O meu pelotão de apenas 4 homens, estava em viagem da costa de Petrov para a cidade de Omskvi, onde havia sido a última vez que tinha visto seu irmão. Todos naquele grupo queriam rever seus familiares, ninguém imaginava que tudo estaria acabado.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Quando chegamos à cidade, perceberam folhetos anunciando a transição do off-line para o online, na CyberCity através do Amotine na prisão de Krestymov. Esse era um dos pontos da cidade de transição, onde muitos engenheiros foram imputados no SOV.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Eu, ao chegar em Krestymov decidi procurar o local onde os humanos estavam.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Eis que o meu pelotão acha os corpos de seus familiares, percebem que estão muito debilitados, mas ainda vivos. Todos plugados aos amotines, jogados dentro do SOV pelo governo petrove e pela LIFE.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Eu também havia conseguido achar o Jones, ele estava a beira da morte. Eu precisava desconectá-lo do sistema, antes que morresse.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Nós encontramos um armazenamento de Amotines da LIFE, perto da região e nos conectamos ao SOV.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Naquele tempo, havia um software que conseguia identificar novos membros do SOV, usado tanto por engenheiros de software como pela própria LIFE, chamado SystemSoft. O SystemSoft é usado também para localizar pessoas, como se fosse um GPS.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Foi aí que meu irmão, Jones, percebeu que eu, seu irmão havia voltado da guerra e que estava indo atrás dele. ");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Naquele tempo, Jones já estava habituado com a CyberCity e percebeu que aquele seria o momento ideal para executar seu mais novo software, que o colocaria para fora do SOV.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Quando entrei no SOV, todos no SOV obtém o SmartClock, que é um computador de braço dentro da CyberCity. ");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Jones começou a se comunicar comigo e enviou a sua localização dentro do SOV através do seu SmartClock.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Eu descobri sua localização e decidi me separar do pelotão e ir atrás de meu irmão.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – O local combinado era uma praça, na região central de CyberCity.");
        Capitulo_2_3_2.Add("Wing (Pássaro) –...");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Quando os dois chegaram lá, nos abraçamos e ficamos felizes por nos encontrarem. ");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Mas não tivemos muito tempo, até Linda ter descoberto toda a história e ido atrás da gente. ");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Linda também monitorava o SystemSoft, então explica ela saber exatamente quem havia entrado no SOV e onde essa pessoa estava.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Jones já conhecia a Linda, por ser uma famosa vigia de CyberCity, idolatrada como uma guarda e exército de uma pessoa só. Havia cartazes e outdoors com a divulgação de seu serviço.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Nós decidimos correr, fugindo da Linda, em direção à máquina de refrigerantes, aonde Jones iria hackea-la para escaparem do SOV.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Enquanto Jones hackeava a máquina, eu lutei contra Linda para tentarmos ganhar algum tempo. ");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Eu consegui derrubar ela, embora ela tivesse me dado um golpe na minha perna... Como dentro do SOV não sentimos dor, todos os golpes que levei não eram sentidos... Por isso consegui derrubá-la.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Enquanto isso, Jones tinha conseguido desbloquear a máquina. Naquele momento, conseguimos acordar fora do SOV.");
        Capitulo_2_3_2.Add("Coruja (Jones) – Quando acordamos fora do SOV, eu desmaiei por conta de meu corpo debilitado.");
        Capitulo_2_3_2.Add("Coruja (Jones) – Wing decidiu me levar para fora da cidade onde encontramos, por acaso o acampamento de Melinda.");
        Capitulo_2_3_2.Add("Coruja (Jones) – Vimos de longe uma bandeira, por isso pensamos que poderia haver alguém pra ajudar...");
        Capitulo_2_3_2.Add("Coruja (Jones) – Quando saímos de Krestymov, a prisão onde era um dos pontos de input do SOV, os ventos começavam a soprar forte... Estava começando uma tempestade e precisávamos de abrigo urgente...");
        Capitulo_2_3_2.Add("Coruja (Jones) – Melinda havia construído um acampamento, longe de Omskvi e dos Drones, para se manter em segurança. Mas ela não lutava de forma nenhuma contra a LIFE.");
        Capitulo_2_3_2.Add("Coruja (Jones) – Quando a Melinda viu esses dois homens, à beira da morte próximo de seu abrigo, ela decidiu nos ajudar, nos acolher no seu acampamento.");
        Capitulo_2_3_2.Add("Coruja (Jones) – Após um período juntos, com Melinda me cuidando, Wing pergunta quem é ela e como conseguiu sair do SOV.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Ela diz que nunca pertenceu ao SOV, e que na verdade é uma Androtine (Android + Amotine), gerada pela LIFE para criar o caos no mundo, gerando guerras. Mas, seu criador, Asimovitsky, implantou um software chamado EmotionSoftware.exe, onde a tornava praticamente uma humana, pois a partir disso emularia emoções humanas.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Então ela era a versão “boa” da Linda, por isso não causava mal à ninguém e vivia fugindo da LIFE.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Eu questionei o porquê de fugir, sendo que podem lutar contra a LIFE. ");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Eu era capitão de um pelotão do exército Petrov, lutou na guerra contra CairoHill, estava decidido a tentar salvar o pouco da humanidade que ainda restava.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – E Melinda se sentiu atraída pela ideia e lembrou que no apartamento de seu criador, Asimovitsky, havia o início de uma iniciativa que nunca havia se tornado realidade, a iniciativa Animals. ");
        Capitulo_2_3_2.Add("Coruja (Jones) – Naqueles documentos, Asimovitsky dizia que os animais da natureza não seriam atacados pelos drones da LIFE e que máscaras poderiam ser usadas para despistar os Drones, podendo dar acesso à locais ou serem hackeados para atacar a LIFE.");
        Capitulo_2_3_2.Add("Coruja (Jones) – E Melinda deu a ideia de eles começarmos a usar máscaras de Animais e iniciarem a Animals de Asimovitsky, começando uma resistência à LIFE, para salvar a humanidade.");
        Capitulo_2_3_2.Add("Coruja (Jones) – Em homenagem ao Asas de águia, eu e meu irmão construímos máscaras de pássaros e nos juntamos à Melinda para formar a resistência de Asimovitsky, os Animals, contra a LIFE e seu criador.");
        Capitulo_2_3_2.Add("Wing (Pássaro) – Nos juntamos a Melinda em uma causa, para salvar as pessoas de seus amotines desligarem. Precisamos dar um jeito nisso. Ela não está mais entre nós, mas a Animals ainda existe. Vamos invadir o SOV agora.");
        Capitulo_2_3_2.Add("Coruja (Jones) – Acabei de configurar para ao logarmos, entrarmos direto no meu apartamento. Vamos!");

        return Capitulo_2_3_2;
    }

    public List<string> GetCapitulo_2_3_3()
    {
        Capitulo_2_3_3 = new List<string>();

        Capitulo_2_3_3.Add("CAPÍTULO 2.3.3 – INVADINDO O SOV – ESCOLHA 1.2 - CONSEQUÊNCIA 3 - (PUZZLE PULADO – TODOS OS PERSONAGENS VIVOS – SEM DRONES)");

        //Cenário: Dentro do Distrito de Testes.

        Capitulo_2_3_3.Add("Raposa (Melinda) – O SOV será um universo novo pra mim. Nunca estive lá, mas minha irmã, Linda, provavelmente estará nos esperando lá. Mal posso esperar pelo o que vamos encontrar no caminho.");
        Capitulo_2_3_3.Add("Cão (Yael) – (confiante): Vamos conseguir salvar toda a humanidade. Tudo será restaurado. Mas nós precisamos ser fortes. Vamos lutar pra valer lá dentro!");
        Capitulo_2_3_3.Add("Wing (Pássaro) – Vamos conseguir!");
        Capitulo_2_3_3.Add("Coruja (Jones) – Vai dar tudo certo!");
        Capitulo_2_3_3.Add("Raposa (Melinda) – Eu confio em vocês rapazes! Vamos conseguir sim!");
        Capitulo_2_3_3.Add("Wing (Pássaro) – Coruja, o que devemos fazer para nos conectarmos dentro do SOV e irmos direto para seu apartamento lá na CyberCity?");
        Capitulo_2_3_3.Add("Coruja (Jones) – Enquanto a gente conversava eu já configurava tudo. O que vamos fazer é conectar os alimentadores em nós. Nós só precisamos segurar os Amotines, e o SOV será inicializado automaticamente. Não se preocupem, vamos todos para o mesmo lugar. Meu apartamento é seguro.");


        //Cenário: Logotipo do SOV by LIFE iniciando
        Capitulo_2_3_3.Add("L.I.A. - Inicializando SOV... Bem-vindo ao Sistema Operacional Virtual! Desenvolvido pela corporação LIFE. ");
        Capitulo_2_3_3.Add("L.I.A. - Em breve você estará em um mundo inteiramente virtual. ");
        Capitulo_2_3_3.Add("L.I.A. - A nossa cidade no nosso mundo se chama CyberCity.");
        Capitulo_2_3_3.Add("L.I.A. - Haha... Eu nem me apresentei. Meu nome é L.I.A., Lua, Inteligência Artificial da LIFE. Mas pode me chamar só de LIA, ok? 😊");
        Capitulo_2_3_3.Add("L.I.A. – Percebi que você é novo... E não possui nenhuma segurança, interessante.");
        Capitulo_2_3_3.Add("Cão (Yael) – O que quer dizer com isso?");
        Capitulo_2_3_3.Add("L.I.A. – Nada! ");
        Capitulo_2_3_3.Add("L.I.A. – Em outro momento, quero contar a história da LIFE. Continue nessa jornada para conseguir descobrir mais do nosso universo. ");
        Capitulo_2_3_3.Add("L.I.A. – Em breve nos encontraremos de novo! Até logo 😊");
        Capitulo_2_3_3.Add("Cão (Yael) – OK...");

        //Cenário: Lobby do SOV – Apartamento de Jones.");
        Capitulo_2_3_3.Add("Coruja (Jones) – Enfim, conseguimos entrar no SOV. Agora podemos continuar nossa luta.");
        Capitulo_2_3_3.Add("Raposa (Melinda) – Cão, tenho um presente para você. Quando deixei a LIFE, na época em que ainda nem tudo era dentro do SOV e vi meu pai, meu criador morrer, ele deixou isso pra mim. É um diário, ele conta tudo o que viveu. Você busca respostas para saber quem matou seu amigo em Krestymov. Talvez esse livro te ajude a entender esse universo misterioso.");
        Capitulo_2_3_3.Add("Cão (Yael) – Uau! Vai ajudar muito esse livro, obrigado Raposa.");
        Capitulo_2_3_3.Add("Raposa (Melinda) – (Feliz) – Vai ser mais útil com você. ");
        Capitulo_2_3_3.Add("Cão (Yael) – Mas como enfrentaremos a LIFE? Sem drones?");
        Capitulo_2_3_3.Add("Wing (Pássaro) – Jones modificou nosso sistema, podemos gerar dano e sofrer danos dentro desse servidor. Isso significa que podemos bater com nossas mãos, mas podemos morrer da mesma forma.");
        Capitulo_2_3_3.Add("Cão (Yael) – Conseguimos chegar até aqui vivos, acredito que vamos conseguir. E então, para onde vamos?");
        Capitulo_2_3_3.Add("Cenário: Mapa da CyberCity.");
        Capitulo_2_3_3.Add("Coruja (Jones) – Vamos pegar o transporte na Estação 14-7.");
        Capitulo_2_3_3.Add("Coruja (Jones) – Depois vamos pegar o trem para a Estação 25-6");
        Capitulo_2_3_3.Add("Coruja (Jones) – De lá vamos descer na frente da LIFE.");
        Capitulo_2_3_3.Add("Wing (Pássaro) – Vamos?");
        Capitulo_2_3_3.Add("Coruja (Jones) – Vamos!");

        return Capitulo_2_3_3;
    }


    public List<string> GetCapitulo_2_4()
    {
        Capitulo_2_4 = new List<string>();

        Capitulo_2_4.Add("Cão(Yael) – Será que leio esse livro, que Melinda deixou pra mim?");
        Capitulo_2_4.Add("Decisão:");

        //Ler o diário de Asimovitsky
        //Não ler o diário de Asimovitsky

        return Capitulo_2_4;
    }

    public List<string> GetCapitulo_2_4_1()
    {
        Capitulo_2_4_1 = new List<string>();

        //Trecho muito longo (cerca de 8 páginas)

        Capitulo_2_4_1.Add("CAPÍTULO 2.4.1 – O DIÁRIO DE ASIMOVITSKY");
        Capitulo_2_4_1.Add("- Página 1 – O diário é descoberto");
        Capitulo_2_4_1.Add("Certo dia em uma biblioteca na escola pública da cidade de cidade de Sévero, havia uma entrega de um carregamento de livros na porta.");
        Capitulo_2_4_1.Add("Entregador - Bom dia! Entrega!");
        Capitulo_2_4_1.Add("Senhora M.A. - Olá! Tudo bem? Pode entrar por favor! Pode deixar o carregamento à esquerda, na estante número A25. ");
        Capitulo_2_4_1.Add("Entregador - Pode deixar comigo - eu não acredito que vou descarregar toda essa pilha de livros sozinho, o Cesar ainda me paga por me deixar sozinho hoje -.");
        Capitulo_2_4_1.Add("Enquanto o entregador anda até a fileira dos livros, despencava um pedaço de vidro do lustre e na queda instalou-se entre uma das rodinhas do carrinho de livros, fazendo-o travar. Logo em seguida, aquele entregador escorregou e caiu na escadaria da livraria.");
        Capitulo_2_4_1.Add("Entregador - Essa não!!!");
        Capitulo_2_4_1.Add("O entregador tenta se agarrar na barra de aço do carrinho, mas a pilha de livros sendo mais pesada o joga em direção à escadaria. Todos os livros caem junto com o rapaz.");
        Capitulo_2_4_1.Add("O rapaz torce o pé em um livro curiosamente peculiar. Um livro de capa preta cuja escrita condiz com “M.S” em letras cursivas e prateadas.");
        Capitulo_2_4_1.Add("O livro era um diário em branco. Pertencia a um homem chamado Modrek Amorit. Eu, sendo um jovem e inexperiente, guardei aquele livro para mim. Anotei minhas lembranças mais pertinentes e sempre o guardei comigo no bolso da camisa, para anotar minhas lembranças...");
        Capitulo_2_4_1.Add("Após ouvir o barulho, a senhora M.A vai até o local e se espanta com o ocorrido. A cena escurece ao som de uma ambulância.");

        Capitulo_2_4_1.Add("- Página 2 – Os pais se separam");
        Capitulo_2_4_1.Add("- Amor, eu te amo. Vamos para a cama...");
        Capitulo_2_4_1.Add("- (Chorando) – Eu... eu não quero, eu não me sinto bem... você me consome, me faz me sentir mal.");
        Capitulo_2_4_1.Add("- Tudo o que eu quero é te fazer feliz...");
        Capitulo_2_4_1.Add("- Mentira! Você só quer meu corpo, não sente nada por mim.");
        Capitulo_2_4_1.Add("- Mas eu... eu te amo!...");
        Capitulo_2_4_1.Add("- Você me usa, como uma luva e joga fora...");
        Capitulo_2_4_1.Add("- Eu quero o melhor para você!");
        Capitulo_2_4_1.Add("- Eu só quero ir embora, fugir daqui e nunca mais te ver!");
        Capitulo_2_4_1.Add("- Então vá!");
        Capitulo_2_4_1.Add("- Viu! Se você me amasse você não diria isso. Você vive em um mundo perdido e sem luz, sua alma já é como se fosse pó da terra... você nunca me mereceu e nunca vai me merecer.");
        Capitulo_2_4_1.Add("- Tudo o que você fala de mim, é como se fosse uma facada no coração...");
        Capitulo_2_4_1.Add("- Você não tem coração, você me traiu, você me usou, me roubou... eu quero terminar agora... nunca mais eu quero te ver na minha vida. – Procurando o telefone do táxi -.");
        Capitulo_2_4_1.Add("- Amor... pensa bem. Eu nunca quis fazer mal para você, mas se você quiser isso mesmo, nunca vou te impedir de forma alguma. Eu vou te deixar para sempre se você quiser. Mas e as meninas? ");
        Capitulo_2_4_1.Add("- A meninas? Elas vão ficar bem comigo... elas vêm comigo e nunca mais te verão...");
        Capitulo_2_4_1.Add("- Eu não entendo como tudo desaba dessa forma, você nunca sentiu nada por mim?");
        Capitulo_2_4_1.Add("- Você me enganou por todo esse tempo.");
        Capitulo_2_4_1.Add("- Eu nunca te enganei, eu sempre fui sincero...");
        Capitulo_2_4_1.Add("- O táxi chega –");
        Capitulo_2_4_1.Add("- Eles se olham -");
        Capitulo_2_4_1.Add("- O relógio em cima da porta de saída marca 23:53 -");
        Capitulo_2_4_1.Add("- A porta está entreaberta -");
        Capitulo_2_4_1.Add("- Ela pega o táxi, as crianças e nunca mais volta...-");

        Capitulo_2_4_1.Add("- Página 3 – A paz que ele procurava");
        Capitulo_2_4_1.Add("Por longos dias ele suportou suas dores consigo mesmo, sem manifestar de forma alguma.");
        Capitulo_2_4_1.Add("Sei sobre tudo o que qualquer jovem pensa.");
        Capitulo_2_4_1.Add("Quando tá na merda.");
        Capitulo_2_4_1.Add("Quando acha que a vida não faz sentido, quando não consegue as coisas que quer.");
        Capitulo_2_4_1.Add("Enfim...");
        Capitulo_2_4_1.Add("Igual a mim agora.");
        Capitulo_2_4_1.Add("Mas, a vida... a vida é assim mesmo.");
        Capitulo_2_4_1.Add("Tem que ser assim, para depois ser melhor. ");
        Capitulo_2_4_1.Add("E dar um bom sentido nas coisas ao nosso redor.");
        Capitulo_2_4_1.Add("Um dia sua visão irá mudar.");
        Capitulo_2_4_1.Add("As coisas melhoram.");
        Capitulo_2_4_1.Add("Ele estava à procura da paz que sempre quis. ");
        Capitulo_2_4_1.Add("E quando a encontrou, assim ele ficou... em paz.");
        Capitulo_2_4_1.Add("Somos eternos aprendizes da vida.");

        Capitulo_2_4_1.Add("- Página 4 – A influência daquele homem chamado Malev.");
        Capitulo_2_4_1.Add("'Me disseram certa vez que sou capaz de influenciar e mudar as pessoas.");
        Capitulo_2_4_1.Add("Talvez eu te mude... ou talvez não'.");
        Capitulo_2_4_1.Add("Foi o que ouvi daquele homem quando o conheci. ");

        Capitulo_2_4_1.Add("- Página 5 – As coisas nem sempre são como queremos.");

        Capitulo_2_4_1.Add("Por muito tempo as coisas deram certo. ");
        Capitulo_2_4_1.Add("As coisas deram certo na criação da LIFE.");
        Capitulo_2_4_1.Add("Por muito tempo tudo aconteceu, mas nem tudo era o que ele queria. ");
        Capitulo_2_4_1.Add("As coisas são assim...");
        Capitulo_2_4_1.Add("Malev sempre quis mais. Sempre quis o que a União do Estado tinha em mãos: poder, controle sobre as pessoas. Não se tratava mais de riquezas e sim de vingança e loucura daquele Homem.");
        Capitulo_2_4_1.Add("Nós criamos uma espécie híbrida de seres humanoides, os androtines. Uma espécie híbrida, que usa membros orgânicos e membros tecnológicos, alimentado pela principal tecnologia da LIFE: o Amotine.");
        Capitulo_2_4_1.Add("Malev e Eu criamos duas androtines, Malev depositou todo o seu ódio em Linda enquanto eu depositei todo o meu amor em Melinda. ");

        Capitulo_2_4_1.Add("- Página 6 – Linda, a assassina.");
        Capitulo_2_4_1.Add("Uma assassina.");
        Capitulo_2_4_1.Add("Uma assassina que sabia o que fazia. Ela estava apenas cumprindo seu dever.");
        Capitulo_2_4_1.Add("Ele sabia que ela nunca mais veria seus amigos, parentes, conhecidos... ");
        Capitulo_2_4_1.Add("Ele sabia que não tinha nada a perder.");
        Capitulo_2_4_1.Add("Ela tinha algo a fazer e isso era matar. Mas não era quaisquer mortes. Eram mortes especiais. Especiais para ele, Malev e péssimo para os outros países, CairoHill em especial. Ele já tinha tudo planejado. Ele sabia o que estava fazendo. Mas ela...  ela era uma simples marionete.");
        Capitulo_2_4_1.Add("Essa é Linda. Programada para matar qualquer um que estiver em seu caminho. Ela foi criada para obedecer às ordens de Malev, matar alvos políticos e criar o caos no mundo. Esse foi um dos motivos da guerra nuclear, a última guerra mundial.");
        Capitulo_2_4_1.Add("Malev sempre prezou por poder. Linda foi apenas uma arma letal usada para causar dor e sofrimento.");
        Capitulo_2_4_1.Add("As coisas fazem e perdem o sentido de repente. Tudo é superficial. Tudo é industrial. Produzidos para produzirem. Serem o que é. ");
        Capitulo_2_4_1.Add("Não se sabe como tudo tinha chegado naquele momento. Apenas tinha chegado.");
        Capitulo_2_4_1.Add("Quando ele se encontrou isolado, em seu próprio mundo... esteve só.");
        Capitulo_2_4_1.Add("Pensamos que não somos animais, mas somos. Ódio leva a mais ódio.");

        Capitulo_2_4_1.Add("Página 7 – Malev.");
        Capitulo_2_4_1.Add("De todas as angústias que já havia vivido, aquela estava sendo mais uma. Todos os sentimentos quando batem à porta, vêm como um soco só. ");
        Capitulo_2_4_1.Add("Mas, o importante é saber lidar com o fracasso, saber lidar com a derrota. Saber que é sim alguém que não agrega em nada. Não para não se sentir bem, mas pelo contrário. ");
        Capitulo_2_4_1.Add("Às vezes devemos ser que nem os animais, inocentes, comem, dormem, se reproduzem ou apenas fazem sexo. Simplesmente por sobrevivência.");
        Capitulo_2_4_1.Add("Não sabemos quando será nosso fim, assim como não sabemos como foi o início. E isso não importa.");
        Capitulo_2_4_1.Add("Apenas devemos viver de forma simples, não importando fazer parte de um grupo social, porque na realidade aquele grupo já também não agrega em nada.");
        Capitulo_2_4_1.Add("As coisas são desnecessárias. Por isso viver como um animal, deveria ser um objetivo.");
        Capitulo_2_4_1.Add("Um ser animal, que passa da forma humana para um cão. Um cão que aprendeu a ser, a sobreviver, a lidar com a ausência da vida e do prazer. Um ser Epicteto. Que descobriu sua felicidade, nas coisas mais banais. Um tênis no lugar, um bicho fazendo-o companhia... tudo estava no seu lugar.");
        Capitulo_2_4_1.Add("Os tempos difíceis o tornaram um homem forte, capaz de saber lidar até com a própria morte.");
        Capitulo_2_4_1.Add("Tudo fazia sentido agora, quando a paz no seu interior era compreendida e seu coração ardia em simplicidade.");

        Capitulo_2_4_1.Add("Página 8 – Mais uma reflexão.");
        Capitulo_2_4_1.Add("Você é um produto. Um número. Um Zé Ninguém. Um zero à esquerda.");
        Capitulo_2_4_1.Add("São palavras que ele pensou quando estava quase na hora.");
        Capitulo_2_4_1.Add("Às coisas que perdem o sentido de repente, eu digo o quanto são vazias e ineficazes. Não tem importância. ");
        Capitulo_2_4_1.Add("Quem perde sua vida, encontrará? ");
        Capitulo_2_4_1.Add("Seus problemas, são importantes, mas você não.");
        Capitulo_2_4_1.Add("Sim. O fim está próximo. E você sente. Você sabe. Você não hesita em pensar.");
        Capitulo_2_4_1.Add("Você é sim diferente. Único. Mas eles não sabem. E se Jesus não soubesse que ele era Jesus?");


        Capitulo_2_4_1.Add("Página 9 (Final) – Meu leito de morte, uma mensagem para você.");
        Capitulo_2_4_1.Add("“O livro era um diário em branco. Pertencia a um homem chamado Modrek Amorit. Eu, sendo um jovem e inexperiente, guardei aquele livro para mim. Anotei minhas lembranças mais pertinentes”.");
        Capitulo_2_4_1.Add("Anotei os meus demônios e meus anjos. O darei para ela, minha querida filha não humana, Melinda. A minha querida androtine. A quem deve salvar esse mundo dele, o criador do SOV – Malev - e da escravidão virtual. ");
        Capitulo_2_4_1.Add("Melinda, salve o mundo. Use máscaras de animais, pois os drones da LIFE dificilmente verão você. Use os drones contra a LIFE, contra o Criador.");
        Capitulo_2_4_1.Add("Eu digo que não consigo e que está tudo tão difícil... sei que consigo. Sei que sou forte, sempre fui. Eu olho para o meu passado e vejo o quanto eu sofri e o quanto fui forte em aguentar tantas e tantas coisas. Sei que elas me machucaram. Sei que dói lembrar dessas coisas. Às vezes são fantasmas do passado que me cercam, não me permitindo evoluir.");
        Capitulo_2_4_1.Add("Ninguém disse que seria fácil, ninguém me disse que seria simples. ");
        Capitulo_2_4_1.Add("Não existe direção certa, mas por isso continuar é a melhor direção. Tenho que terminar o que comecei. Tenho que me libertar, tenho que provar que consigo ser maior. Tenho que acreditar que algo maior vai acontecer. Não posso deixar tudo ser em vão.");
        Capitulo_2_4_1.Add("Ninguém disse nada contra você. E se disse, e daí? Se disseram é porque sabem que você é tão grande a ponto de incomodá-los... quando você não faz diferença, você não incomoda.");
        Capitulo_2_4_1.Add("Você não está aqui para ninguém... você está aqui para si mesmo, para crescer. Para ser melhor.");
        Capitulo_2_4_1.Add("Você é tão grande, mas tão grande... Você não sabe o seu verdadeiro valor... Você vale muito.");
        Capitulo_2_4_1.Add("No fim, voltamos para o começo. Vai dar tudo certo. Apenas continue e ignore o que disserem, você consegue. Estarei aqui, do seu lado, te dando forças para conseguir evoluir...");
        Capitulo_2_4_1.Add("Eu já falei do deserto? Creio que não. O deserto é um lugar solitário, sabotador e muitas vezes cruel. O deserto é um lugar, que em algum momento todos vão ir. Não importa quem.");
        Capitulo_2_4_1.Add("A questão é que o deserto é um momento da vida, onde você estará sozinho, cheio de problemas e muitas vezes desejará desistir. O deserto, sempre é um local tão solitário, que a única companhia é você mesmo. Mesmo sabendo que existem outras pessoas que você pode contar, no deserto você deverá agir sozinho. ");
        Capitulo_2_4_1.Add("É no deserto que você deverá enfrentar o seu maior inimigo, onde ele não deixará você avançar, enquanto ele te perseguir.");
        Capitulo_2_4_1.Add("O deserto é um local onde você se sentirá tão sozinho, que não verá nada, além dos problemas.");
        Capitulo_2_4_1.Add("Porém, o deserto é uma fase. Mas depende de você, para sair dessa fase. Se não você ficará 40 anos preso nesse deserto e não chegará em lugar algum. Acontece que, você tem que continuar até cruzar esse deserto, derrotando o seu maior inimigo que é você mesmo. E derrotando os seus medos, se superando.");
        Capitulo_2_4_1.Add("No fim, após o deserto, sempre tem um Oasis te esperando. Então, cruzar o deserto vale a pena.");
        Capitulo_2_4_1.Add("É engraçado o quanto é a vida.");
        Capitulo_2_4_1.Add("Lembro de uma vez que eu falei para um amigo meu, que éramos como carros. ");
        Capitulo_2_4_1.Add("Somos feitos de peças mecânicas, não elétricas.");
        Capitulo_2_4_1.Add("Mecânicas porque precisamos de manutenção.");
        Capitulo_2_4_1.Add("E nossas pastilhas de freios, assim como as dos carros, são uma das primeiras a começarem a darem defeito.");
        Capitulo_2_4_1.Add("Depois, tem o óleo do motor, do câmbio, a gasolina, a bomba de combustível, os faróis, os acabamentos, os pneus, e muitas outras peças.");
        Capitulo_2_4_1.Add("Eu falo dos freios porque são as pastilhas dos freios que freiam a gente. ");
        Capitulo_2_4_1.Add("São elas que nos sustentam. E quando não tem mais freio, não podemos parar. E se não podemos parar, vamos bater. E se bater, vai ser um acidente. E se der um acidente, podemos morrer.");
        Capitulo_2_4_1.Add("E mais uma coisa, o código... Use o código para salvar você e quem estiver com você, contra a Linda. O código para desativar ela é 7898, até onde sei podem existir outros códigos... Ele vai te salvar do pior que pode acontecer.");
        Capitulo_2_4_1.Add("Você é minha última esperança, Adeus minha filha.");

        return Capitulo_2_4_1;
    }

    public List<string> GetCapitulo_3()
    {
        Capitulo_3 = new List<string>();

        //Cenário: Estação 14-7.
        Capitulo_3.Add("CAPÍTULO 3 – CONFLITOS NA CYBERCITY - ESCOLHA 1.1 – CONSEQUÊNCIA 1 (OS DRONES ESTÃO JUNTO NA INVASÃO À LIFE, TODOS OS PERSONAGENS VIVOS)");
        Capitulo_3.Add("Coruja (Jones) – Devemos pegar esse trem para a avenida 25-6. De lá vamos descer na frente da LIFE.");
        Capitulo_3.Add("Wing (Pássaro) – Mal posso pressentir o que pode nos aguardar nessa estação.");
        Capitulo_3.Add("Cão (Yael) – Pode ser que encontremos perigo?");
        Capitulo_3.Add("Wing (Pássaro) – Nem me fale, tenho certeza de que Linda tem monitorado todos os nossos passos.");
        Capitulo_3.Add("Raposa (Melinda) – Acredite, ela sabe onde estamos. Tenho certeza de que temos muitas chances de encontrarmos ela aqui mesmo nessa estação.");
        Capitulo_3.Add("Coruja (Jones) – Sorte que temos os drones, programei eles para que consigam atirar e causar dano mesmo dentro do SOV. Então, estamos seguros.");
        Capitulo_3.Add("Cão (Yael) – Vamos apreciar a viagem então!");
        Capitulo_3.Add("Cão (Yael) – ... Espera!");
        Capitulo_3.Add("Cão (Yael) – Vocês também estão ouvindo um som estranho... acho que o trem bateu em alguma coisa!");
        Capitulo_3.Add("Raposa (Melinda) – Acho que sei o que está acontecendo... Linda, ela chegou.");
        Capitulo_3.Add("Coruja (Jones) – Estamos preparados para o que vier...");
        Capitulo_3.Add("Wing (Pássaro) – Linda! Temos um assunto para resolver, e sim, é pessoal!");
        Capitulo_3.Add("Linda – Vocês falam demais... Hahaha!");
        Capitulo_3.Add("Linda – Nem parecem que sabem que vão morrer...");
        Capitulo_3.Add("Raposa (Melinda) – Podemos resolver isso de outras formas Linda... ");
        Capitulo_3.Add("Linda – Minha irmãzinha... de pais diferentes... Desde que a L.I.A. me contou que vocês haviam entrado no SOV, não precisei fazer muito... Só localizei vocês pelo rastreador SystemSoft. ");
        Capitulo_3.Add("Linda – Naquele momento eu coloquei você em primeiro lugar na minha lista de mortes... O projeto Me-Linda só pode ter uma Linda, eu.");
        Capitulo_3.Add("Raposa (Melinda) – Você é quem sabe...");
        Capitulo_3.Add("Coruja (Jones) – Drones! Atirem!!");
        Capitulo_3.Add("Drones – Atirando");
        Capitulo_3.Add("Linda – (Suspirando, muito debilitada) – Não... Como vocês conseguiram fazer isso?... Eu sou indestrutível...");
        Capitulo_3.Add("Wing (Pássaro) – Jones, acabe com ela! Faça-a pagar!");
        Capitulo_3.Add("Raposa (Melinda) – Espera, Cão, o você quer?");

        Capitulo_3.Add("Decisão:");
        
        //Escolha A: Usar o Código: 7898 (extraído do diário de Asimovitsky)
        //Escolha B: Usar o Código: 7562 (código aleatório)

        return Capitulo_3;
    }

    public List<string> GetCapitulo_3_1_1()
    {
        Capitulo_3_1_1 = new List<string>();

        Capitulo_3_1_1.Add("CAPÍTULO 3.1.1 – O CÃO DECIDE O DESTINO DE LINDA - ESCOLHA 1.1 – CONSEQUÊNCIA 1 (OS DRONES ESTÃO JUNTO NA INVASÃO À LIFE, TODOS OS PERSONAGENS VIVOS) - ESCOLHA A (LINDA SE TORNA ALIADA)");

        //Cenário: Estação 14-7.
        Capitulo_3_1_1.Add("Cão (Yael) – Eu li o diário, sei o que estou fazendo... Linda, ativar código 7898.");
        Capitulo_3_1_1.Add("Linda – (L.I.A): Projeto Me-Linda desativado. Reconhecendo amigos... Carregando sistema.");
        Capitulo_3_1_1.Add("Linda (confusa) – Ahhh que dor de cabeça... O que houve?!");
        Capitulo_3_1_1.Add("Raposa (Melinda) – (feliz) – Ela foi restaurada. Ela é uma androtine normal agora! Irmã!! Finalmente posso te abraçar. Conseguimos te salvar.");
        Capitulo_3_1_1.Add("Wing (Pássaro) – Nem acredito que conseguimos salvar a “temida assassina” haha.");
        Capitulo_3_1_1.Add("Coruja (Jones) – Conseguimos! Graças a Yael, o nosso Cão!");
        Capitulo_3_1_1.Add("Linda (confusa) – Obrigada Yael ou Cão, como quiser... Eu estava surtada. Agora sou uma pessoa normal. Quero ajudar vocês no que for preciso. ");
        Capitulo_3_1_1.Add("Raposa (Melinda) – Estamos a caminho da LIFE. Vamos derrotar Malev, o seu criador e vamos restaurar as baterias dos Amotines... As pessoas devem poder escolher qual caminho devem seguir. Mas serem escravizadas, isso é demais.");
        Capitulo_3_1_1.Add("Linda – Podem contar comigo. Vamos salvar a humanidade e destruir a LIFE.");
        Capitulo_3_1_1.Add("Coruja (Jones) – Chegamos na Estação 25-6. Aqui descemos, a LIFE fica logo adiante.");


        return Capitulo_3_1_1;
    }

    public List<string> GetCapitulo_3_1_2()
    {
        Capitulo_3_1_2 = new List<string>();

        Capitulo_3_1_2.Add("CAPÍTULO 3.1.2 – O CÃO DECIDE O DESTINO DE LINDA - ESCOLHA 1.1 – CONSEQUÊNCIA 1 (OS DRONES ESTÃO JUNTO NA INVASÃO À LIFE, TODOS OS PERSONAGENS VIVOS) - ESCOLHA B (LINDA É DESTRUÍDA)");

        //Cenário: Estação 14-7.
        Capitulo_3_1_2.Add("Cão (Yael) – Eu não li o diário, mas sei o que estou fazendo... Linda, ativar código 7562.");
        Capitulo_3_1_2.Add("Linda – (L.I.A): Projeto Me-Linda sendo autodestruído. Iniciando contagem regressiva para destruição total... 5... 4... 3... 2... 1...");
        Capitulo_3_1_2.Add("Linda – (L.I.A): Destruindo sistema.");
        Capitulo_3_1_2.Add("Linda – (L.I.A): ... Puffff");
        Capitulo_3_1_2.Add("Raposa (Melinda) – Ela era minha irmã, mas sei que tomou a melhor decisão para os Animals Cão. Confio na sua decisão. Sei que fará sentido...");
        Capitulo_3_1_2.Add("Coruja (Jones) – Conseguimos vencer a Linda... Sinto muito por isso Raposinha.");
        Capitulo_3_1_2.Add("Wing (Pássaro) – Estamos quase concluindo nosso objetivo. Falta pouco para salvarmos toda a humanidade. Estamos meio caminho andado.");
        Capitulo_3_1_2.Add("Coruja (Jones) – Chegamos na Estação 25-6. Aqui descemos, a LIFE fica logo adiante.");



        return Capitulo_3_1_2;
    }

    public List<string> GetCapitulo_3_2()
    {
        Capitulo_3_2 = new List<string>();


        Capitulo_3_2.Add("CAPÍTULO 3.2 FINAL 5– CONFLITOS NA CYBERCITY - ESCOLHA 1.1 – CONSEQUÊNCIA 2 (MELINDA MORRE DEVIDO UM DOS DRONES SER ALERTADO DURANTE O HACKEAMENTO. JONES, WING E YAEL PERMANECEM VIVOS. ELES NÃO CONSEGUEM A AJUDA DOS DRONES.)");

        //Cenário: Estação 14-7.
        Capitulo_3_2.Add("Coruja (Jones) – Devemos pegar esse trem para a avenida 25-6. De lá vamos descer na frente da LIFE.");
        Capitulo_3_2.Add("Wing (Pássaro) – Mal posso pressentir o que pode nos aguardar nessa estação.");
        Capitulo_3_2.Add("Cão (Yael) – Pode ser que encontremos perigo?");
        Capitulo_3_2.Add("Wing (Pássaro) – Nem me fale, tenho certeza de que Linda tem monitorado todos os nossos passos.");
        Capitulo_3_2.Add("Cão (Yael) – Vocês também estão ouvindo esse barulho? Parece que o trem bateu em alguma coisa...");
        Capitulo_3_2.Add("Wing (Pássaro) – Acho que a Linda nos encontrou!");
        Capitulo_3_2.Add("Wing (Pássaro) –...");
        Capitulo_3_2.Add("Linda – Vocês falam muito pouco... Hahaha!");
        Capitulo_3_2.Add("Linda – Ué, onde está minha irmãzinha?");
        Capitulo_3_2.Add("Coruja (Jones) – Chegou tarde, a raposinha se foi... ");
        Capitulo_3_2.Add("Linda – É assim que vocês chamam Melinda? Raposa? Por quê? Aliás, por que vocês estão usando máscara de animais??");
        Capitulo_3_2.Add("Wing (Pássaro) – Nós usamos máscaras para despistar os drones da LIFE, dessa forma eles não nos atacam e conseguimos domesticá-los. Ela escolheu o Alter Ego dela, como sendo uma raposa. Raposa porque era um animal que ela admirava.");
        Capitulo_3_2.Add("Linda – Parece que não deu muito certo o plano de vocês... Melinda deveria ver isso, a morte de vocês. Quem sabe em outra vida, não é?!");
        Capitulo_3_2.Add("Linda – Quem irá morrer primeiro? O Cãozinho? Ou a Corujinha?");
        Capitulo_3_2.Add("Wing (Pássaro) – Você vai pagar por tudo!!!!");
        Capitulo_3_2.Add("Wing (Pássaro) (Wing tenta golpear Linda, mas é atingido no coração, caindo automaticamente)");
        Capitulo_3_2.Add("Coruja (Jones) – Meu irmão!! Você o matou!!! Você me paga!!");
        Capitulo_3_2.Add("Coruja (Jones) (Jones tenta dar uma investida na Linda, porém com suas mãos de aço, ela o mata com apenas um golpe).");
        Capitulo_3_2.Add("Cão (Yael) (chocado) – Você... você matou meus amigos, quem me salvaram.");
        Capitulo_3_2.Add("Cão (Yael) – Você conseguiu, você venceu. Nós, a Animals não é nada. Vocês conseguiram vencer...");
        Capitulo_3_2.Add("Linda – Quais são as suas últimas palavras Cão?");
        Capitulo_3_2.Add("Cão (Yael) – Quando eu vi que todos os meus objetivos na vida já haviam se tornado pó e que nada mais importava, me perguntei: E agora? O que faço?");
        Capitulo_3_2.Add("Cão (Yael) – Nunca mais soube responder essa pergunta e os meus dias começaram a se tornar como cinzas novamente.");
        Capitulo_3_2.Add("Cão (Yael) – Sempre me vi no futuro como alguém bem-sucedido, mas no fim o que me tornei foi apenas um homem que sobreviveu. Se sobreviver significa fortaleza, onde está minha força agora?");
        Capitulo_3_2.Add("Cão (Yael) – Eu sempre me achei especial, mesmo sem um bom motivo aparente. Mas sempre tem um momento na vida que perdemos todas as esperanças, todas as nossas ambições, nossa vontade de fazer acontecer.");
        Capitulo_3_2.Add("Cão (Yael) – Eu não tenho mais nada, não sou nada...");
        Capitulo_3_2.Add("Cão (Yael) – Nesse deserto, pude olhar para mim e ver que o que resta é apenas esperar a morte.");
        Capitulo_3_2.Add("Linda – Muito bem, agora chega de lamentações...");
        Capitulo_3_2.Add("Linda (Mata Yael, o Cão com um golpe em seu coração, enquanto Yael se ajoelhava).");

        //Final 5


        return Capitulo_3_2;
    }

    public List<string> GetCapitulo_3_3()
    {
        Capitulo_3_3 = new List<string>();

        Capitulo_3_3.Add("CAPÍTULO 3.3 – CONFLITOS NA CYBERCITY - ESCOLHA 1.2 - CONSEQUÊNCIA 3 - (PUZZLE PULADO – TODOS OS PERSONAGENS VIVOS – SEM DRONES)");
        //Cenário: Estação 14-7.

        Capitulo_3_3.Add("Coruja (Jones) – Devemos pegar esse trem para a Estação 25-6. De lá vamos descer na frente da LIFE.");
        Capitulo_3_3.Add("Wing (Pássaro) – Mal posso pressentir o que pode nos aguardar nessa estação.");
        Capitulo_3_3.Add("Cão (Yael) – Pode ser que encontremos perigo?");
        Capitulo_3_3.Add("Wing (Pássaro) – Nem me fale, tenho certeza de que Linda tem monitorado todos os nossos passos.");
        Capitulo_3_3.Add("Raposa (Melinda) – Acho que estou ouvindo algum barulho... Pode ser que o trem tenha batido em algo ou...");
        Capitulo_3_3.Add("Coruja (Jones) – Ou ela chegou... Linda deve estar nos caçando...");
        Capitulo_3_3.Add("Cão (Yael) – Eu não duvido dessa possibilidade.");
        Capitulo_3_3.Add("Linda – Vocês parecem estar tímidos comigo aqui... Hahaha.");
        Capitulo_3_3.Add("Cão (Yael) – Então você é Linda...");
        Capitulo_3_3.Add("Linda – Sim... E vocês devem ser os invasores do SOV, não é?");
        Capitulo_3_3.Add("Raposa (Melinda) – Nós viemos aqui resolver assuntos não tratados.");
        Capitulo_3_3.Add("Linda – Melinda... Minha irmãzinha... Que bom te ver...");
        Capitulo_3_3.Add("Raposa (Melinda) – Você está fora de si Linda...");
        Capitulo_3_3.Add("Linda – Sim... E você veio me matar? Por que EU vou te matar! Ordens de meu criador, Malev.");
        Capitulo_3_3.Add("Linda (Golpeia Coruja e Pássaro, os dois caem no chão.)");
        Capitulo_3_3.Add("Raposa (Melinda) – Yael, faça alguma coisa!");
        Capitulo_3_3.Add("Raposa (Melinda) - ...");
        Capitulo_3_3.Add("Cão (Yael) – L.I.A.! Ativar código!");
        Capitulo_3_3.Add("Linda (L.I.A.) – Qual código você deseja ativar?");
        Capitulo_3_3.Add("Linda – Como isso é possível?");

        Capitulo_3_3.Add("Decisão:");

        //Escolha A: Usar o Código: 7594 (Jones Morre (Linda sobrevive))
        //Escolha B: Usar o Código: 7491 (Wing Morre (Linda sobrevive))
        //Escolha C: Usar o Código: 5897 (Wing e Jones morrem (Linda morre))

        return Capitulo_3_3;
    }

    public List<string> GetCapitulo_3_3_1()
    {
        Capitulo_3_3_1 = new List<string>();

        Capitulo_3_3_1.Add("CAPÍTULO 3.3.1 – CONFLITOS NA CYBERCITY - ESCOLHA 1.2 - CONSEQUÊNCIA 3 - (PUZZLE PULADO – TODOS OS PERSONAGENS VIVOS – SEM DRONES) - ESCOLHA C - JONES MORRE (LINDA SOBREVIVE)");
        //Cenário: Estação 14-7.
        Capitulo_3_3_1.Add("Cão (Yael) – Qualquer código, desde que salve a gente!");
        Capitulo_3_3_1.Add("Cão (Yael) – L.I.A.! Ativar código 7594!");
        Capitulo_3_3_1.Add("Linda (Desnorteada ataca Jones com um golpe em seu coração)");
        Capitulo_3_3_1.Add("Linda – (L.I.A): Projeto Me-Linda desativado. Reconhecendo amigos... Carregando sistema.");
        Capitulo_3_3_1.Add("Linda (confusa) – Ahhh que dor de cabeça... O que houve?!");
        Capitulo_3_3_1.Add("Raposa (Melinda) – (feliz e confusa) – Ela foi restaurada. Ela é uma androtine normal agora! Irmã!! Conseguimos te salvar.");
        Capitulo_3_3_1.Add("Wing (Pássaro) -...");
        Capitulo_3_3_1.Add("Coruja (Jones) (Últimos suspiros) – Wing, missão cumprida meu irmão... Você é o melhor!");
        Capitulo_3_3_1.Add("Wing (Pássaro) – Mas a que custo? Jones morreu...");
        Capitulo_3_3_1.Add("Cão (Yael) – Sinto muito Wing, fiz o meu melhor...");
        Capitulo_3_3_1.Add("Wing (Pássaro) – Eu vou te vingar irmão... Malev pagará.");




        return Capitulo_3_3_1;
    }


    public List<string> GetCapitulo_3_3_2()
    {
        Capitulo_3_3_2 = new List<string>();

        Capitulo_3_3_2.Add("CAPÍTULO 3.3.2 – CONFLITOS NA CYBERCITY - ESCOLHA 1.2 - CONSEQUÊNCIA 3 - (PUZZLE PULADO – TODOS OS PERSONAGENS VIVOS – SEM DRONES) - ESCOLHA D - WING MORRE (LINDA SOBREVIVE)");
        //Cenário: Estação 14-7.
        Capitulo_3_3_2.Add("Cão (Yael) – Qualquer código, desde que salve a gente!");
        Capitulo_3_3_2.Add("Cão (Yael) – L.I.A.! Ativar código 7491!");
        Capitulo_3_3_2.Add("Linda (Desnorteada ataca Wing com um golpe em seu coração)");
        Capitulo_3_3_2.Add("Linda – (L.I.A): Projeto Me-Linda desativado. Reconhecendo amigos... Carregando sistema.");
        Capitulo_3_3_2.Add("Linda (confusa) – Ahhh que dor de cabeça... O que houve?!");
        Capitulo_3_3_2.Add("Coruja (Jones) (desesperado)– Wing!!! Meu irmão...");
        Capitulo_3_3_2.Add("Wing (Pássaro) (Últimos suspiros) – Jones... Me escuta, projeta os outros... Você deve cuidar dos Animals, nossa missão ainda não terminou... Você é meu irmãozinho, eu te amo.");
        Capitulo_3_3_2.Add("Raposa (Melinda) – O Cão fez o que pôde para salvar a todos nós Jones. Wing lutou como um guerreiro, desde a guerra nuclear até agora lutou para ajudar as pessoas. Devemos nossas vidas a ele. Ele é um grande herói. Os Asas de Águia e os Animals serão eternamente gratos à ele.");
        Capitulo_3_3_2.Add("Cão (Yael) – Wing lutou bravamente Jones, agora ele deve descansar.");
        Capitulo_3_3_2.Add("Linda – Eu devo desculpas por isso Jones, agora eu estou do lado dos Animals... Derrotaremos a LIFE juntos.");
        Capitulo_3_3_2.Add("Coruja (Jones) – Vamos derrotar a LIFE.");

        return Capitulo_3_3_2;
    }


    public List<string> GetCapitulo_3_3_3()
    {
        Capitulo_3_3_3 = new List<string>();

        //Cenário: Estação 14-7.

        Capitulo_3_3_3.Add("CAPÍTULO 3.3.3 – CONFLITOS NA CYBERCITY - ESCOLHA 1.2 - CONSEQUÊNCIA 3 - (PUZZLE PULADO – SEM DRONES) - ESCOLHA E- WING E JONES MORREM (LINDA MORRE)");
        Capitulo_3_3_3.Add("Cão (Yael) – Qualquer código, desde que salve a gente!");
        Capitulo_3_3_3.Add("Cão (Yael) – L.I.A.! Ativar código 5897!");
        Capitulo_3_3_3.Add("Linda (Desnorteada, ataca Wing e Jones ao mesmo tempo, com dois golpes em seus corações)");
        Capitulo_3_3_3.Add("Coruja (Jones) (suspiro final) -...");
        Capitulo_3_3_3.Add("Wing (Pássaro) (suspiro final) -...");
        Capitulo_3_3_3.Add("Cão (Yael) – Nãoooo!!! ");
        Capitulo_3_3_3.Add("Linda (L.I.A.) – Sistema sendo destruído em 3... 2... 1...");
        Capitulo_3_3_3.Add("Linda (L.I.A.) – puff...");
        Capitulo_3_3_3.Add("Raposa (Melinda) – Nãooo!!!");
        Capitulo_3_3_3.Add("Raposa (Melinda) - ...");
        Capitulo_3_3_3.Add("Raposa (Melinda) – Não acredito... Wing e Jones, eles se foram...");
        Capitulo_3_3_3.Add("Cão (Yael) - ...");
        Capitulo_3_3_3.Add("Cão (Yael) – Eles se foram, Linda também... fizemos o que podíamos...");
        Capitulo_3_3_3.Add("Raposa (Melinda) – Vamos enfrentar Malev... Não temos tempo para luto Raposa.");
        Capitulo_3_3_3.Add("Cão (Yael) – Vamos enfrenta-lo.");



        return Capitulo_3_3_3;
    }


    public List<string> GetCapitulo_4_A()
    {
        Capitulo_4_A = new List<string>();

        //Cenário: Edifício da LIFE.
        Capitulo_4_A.Add("CAPÍTULO 4 (FINAL 2 V1) – O CRIADOR, A LIFE E O DESTINO DA HUMANIDADE - ESCOLHA A – COM OS DRONES MELINDA, WING E JONES SOBREVIVEM, LINDA SE TORNA ALIADA E MALEV CAPTURADO. A LIFE É DESTRUÍDA.");
        Capitulo_4_A.Add("Linda – Enfim, chegamos... Aqui é onde devemos encontrar Malev.");
        Capitulo_4_A.Add("Malev – Até que enfim nos encontramos Animals... Estava ansioso para vê-los.");
        Capitulo_4_A.Add("Raposa (Melinda) – Viemos aqui para cobrar tudo o que você fez.");
        Capitulo_4_A.Add("Cão (Yael) – Não tem escapatória Malev. Você matou meu melhor amigo, quando eu estava preso em Krestymov. Me obrigou a ser plugado junto com os presos no SOV. ");
        Capitulo_4_A.Add("Wing (Pássaro) – Eu lutei nas guerras, matei homens bons por sua causa...");
        Capitulo_4_A.Add("Raposa (Melinda) – Você matou Asimovitsky, meu criador.");
        Capitulo_4_A.Add("Linda – Você me obrigou a matar pessoas inocentes, para criar o caos no mundo... ");
        Capitulo_4_A.Add("Coruja (Jones) – Seu plano falhou Malev. Os amotines estão sendo descarregados, as pessoas precisam acordar do SOV antes que seja tarde, antes que elas morram. Não se pode prender ninguém contra sua vontade. ");
        Capitulo_4_A.Add("Coruja (Jones) – Conseguimos escapar do SOV graças a uma falha no sistema, ele não é perfeito.");
        Capitulo_4_A.Add("Malev – Vocês lutaram para chegar até aqui, saíram do meio do mato para tentar ajudar a humanidade. Foi o que eu fiz para proteger meu povo na época.");
        Capitulo_4_A.Add("Malev – Eu não sou um vilão, só queria que o mundo soubesse o que é o sofrimento que vivi.");
        Capitulo_4_A.Add("Malev – O sofrimento que o próprio mundo me causou.");
        Capitulo_4_A.Add("Malev – E meu povo, conseguiria sobreviver independente do que acontecesse. O SOV é um mundo novo, onde podemos ser melhores, livres das limitações humanas...");
        Capitulo_4_A.Add("Malev – Eu não sou um Deus, sou apenas um homem comum...");
        Capitulo_4_A.Add("Malev – Vocês devem recomeçar, a partir daqui... Vocês devem reiniciar os amotines, acordar todas as pessoas antes da morte. Elas devem sim serem questionadas se querem ou não viver nesse mundo virtual.");
        Capitulo_4_A.Add("Malev – Mas eu... eu ficarei online, porque a Terra nunca foi um lugar pra mim. ");
        Capitulo_4_A.Add("Malev - Eu pertenço ao meu próprio mundo....");

        return Capitulo_4_A;
    }


    public List<string> GetCapitulo_4_B()
    {
        Capitulo_4_B = new List<string>();

        //Cenário: Edifício da LIFE.

        Capitulo_4_B.Add("CAPÍTULO 4 (FINAL 2 V2) – O CRIADOR, A LIFE E O DESTINO DA HUMANIDADE - ESCOLHA B - COM OS DRONES MELINDA, WING E JONES SOBREVIVEM, LINDA É DESTRUÍDA E MALEV CAPTURADO. A LIFE É DESTRUÍDA.");
        Capitulo_4_B.Add("Coruja (Jones) - Enfim, chegamos... Aqui é onde devemos encontrar Malev.");
        Capitulo_4_B.Add("Malev – Até que enfim nos encontramos Animals... Estava ansioso para vê-los.");
        Capitulo_4_B.Add("Raposa (Melinda) – Viemos aqui para cobrar tudo o que você fez.");
        Capitulo_4_B.Add("Cão (Yael) – Não tem escapatória Malev. Você matou meu melhor amigo, quando eu estava preso em Krestymov. Me obrigou a ser plugado junto com os presos no SOV. ");
        Capitulo_4_B.Add("Wing (Pássaro) – Eu lutei nas guerras, matei homens bons por sua causa...");
        Capitulo_4_B.Add("Raposa (Melinda) – Você matou Asimovitsky, meu criador.");
        Capitulo_4_B.Add("Coruja (Jones) – Seu plano falhou Malev. Os amotines estão sendo descarregados, as pessoas precisam acordar do SOV antes que seja tarde, antes que elas morram. Não se pode prender ninguém contra sua vontade. ");
        Capitulo_4_B.Add("Coruja (Jones) – Conseguimos escapar do SOV graças a uma falha no sistema, ele não é perfeito.");
        Capitulo_4_B.Add("Malev – Uma pena saber que Melinda não está aqui, mas estou feliz em te ver Melinda. Você é como se fosse uma filha...");
        Capitulo_4_B.Add("Malev – Vocês lutaram para chegar até aqui, saíram do meio do mato para tentar ajudar a humanidade. Foi o que eu fiz para proteger meu povo na época.");
        Capitulo_4_B.Add("Malev – Eu não sou um vilão, só queria que o mundo soubesse o que é o sofrimento que vivi.");
        Capitulo_4_B.Add("Malev – O sofrimento que o próprio mundo me causou.");
        Capitulo_4_B.Add("Malev – E meu povo, conseguiria sobreviver independente do que acontecesse. O SOV é um mundo novo, onde podemos ser melhores, livres das limitações humanas...");
        Capitulo_4_B.Add("Malev – Eu não sou um Deus, sou apenas um homem comum...");
        Capitulo_4_B.Add("Malev – Vocês devem recomeçar, a partir daqui... Vocês devem reiniciar os amotines, acordar todas as pessoas antes da morte. Elas devem sim serem questionadas se querem ou não viver nesse mundo virtual.");
        Capitulo_4_B.Add("Malev – Mas eu... eu ficarei online, porque a Terra nunca foi um lugar pra mim. ");
        Capitulo_4_B.Add("Malev - Eu pertenço ao meu próprio mundo....");


        return Capitulo_4_B;
    }

    public List<string> GetCapitulo_4_C()
    {
        Capitulo_4_C = new List<string>();

        Capitulo_4_C.Add("CAPÍTULO 4 (FINAL 3 V1) – O CRIADOR, A LIFE E O DESTINO DA HUMANIDADE - ESCOLHA C - SEM OS DRONES MELINDA E WING SOBREVIVEM, JONES MORRE, LINDA SE TORNA ALIADA E MALEV É DESTRUÍDO. A LIFE É DESTRUÍDA.");
        //Cenário: Edifício da LIFE.
        Capitulo_4_C.Add("Linda – Enfim, chegamos... Aqui é onde devemos encontrar Malev.");
        Capitulo_4_C.Add("Malev – Até que enfim nos encontramos Animals... Estava ansioso para vê-los.");
        Capitulo_4_C.Add("Raposa (Melinda) – Viemos aqui para cobrar tudo o que você fez.");
        Capitulo_4_C.Add("Cão (Yael) – Não tem escapatória Malev. Você matou meu melhor amigo, quando eu estava preso em Krestymov. Me obrigou a ser plugado junto com os presos no SOV. ");
        Capitulo_4_C.Add("Wing (Pássaro) – Eu lutei nas guerras, matei homens bons por sua causa...");
        Capitulo_4_C.Add("Raposa (Melinda) – Você matou Asimovitsky, meu criador.");
        Capitulo_4_C.Add("Linda – Você me obrigou a matar pessoas inocentes, para criar o caos no mundo... Eu mesma vou te matar Malev. Vou vingar a morte de Jones, das pessoas inocentes.");
        Capitulo_4_C.Add("Malev – Vocês lutaram para chegar até aqui, saíram do meio do mato para tentar ajudar a humanidade. Foi o que eu fiz para proteger meu povo na época.");
        Capitulo_4_C.Add("Malev – Linda, agora você tem acesso ao controle dos amotines. Salve a todos.");
        Capitulo_4_C.Add("Raposa (Melinda) – Linda, termine com isso.");
        Capitulo_4_C.Add("Linda (Com apenas um golpe, Linda mata Malev)");
        Capitulo_4_C.Add("Malev (Suspiro final) -...");
        Capitulo_4_C.Add("Wing (Pássaro) – Terminamos por aqui. Malev não será mais um problema. Agora, só falta restaurar os amotines.");
        Capitulo_4_C.Add("Raposa (Melinda) – Estão sendo restaurados agora.");
        Capitulo_4_C.Add("Linda – É isso? ");
        Capitulo_4_C.Add("Raposa (Melinda) – Acho que terminamos... Que jornada. ");
        Capitulo_4_C.Add("Wing (Pássaro) – Perdemos Jones, mas conseguimos cumprir nosso dever.");
        Capitulo_4_C.Add("Raposa (Melinda) – Então, até a próxima Animals... ");



        return Capitulo_4_C;
    }


    public List<string> GetCapitulo_4_D()
    {
        Capitulo_4_D = new List<string>();


        Capitulo_4_D.Add("CAPÍTULO 4 (FINAL 3 V2) – O CRIADOR, A LIFE E O DESTINO DA HUMANIDADE - ESCOLHA D - SEM OS DRONES MELINDA E JONES SOBREVIVEM, WING MORRE, LINDA SE TORNA ALIADA E MALEV É DESTRUÍDO. A LIFE É DESTRUÍDA.");
        //Cenário: Edifício da LIFE.
        Capitulo_4_D.Add("Linda – Enfim, chegamos... Aqui é onde devemos encontrar Malev.");
        Capitulo_4_D.Add("Malev – Até que enfim nos encontramos Animals... Estava ansioso para vê-los.");
        Capitulo_4_D.Add("Raposa (Melinda) – Viemos aqui para cobrar tudo o que você fez.");
        Capitulo_4_D.Add("Cão (Yael) – Não tem escapatória Malev. Você matou meu melhor amigo, quando eu estava preso em Krestymov. Me obrigou a ser plugado junto com os presos no SOV. ");
        Capitulo_4_D.Add("Raposa (Melinda) – Você matou Asimovitsky, meu criador.");
        Capitulo_4_D.Add("Linda – Você me obrigou a matar pessoas inocentes, para criar o caos no mundo... Eu mesma vou te matar Malev. Vou vingar a morte de Jones, das pessoas inocentes.");
        Capitulo_4_D.Add("Malev – Vocês lutaram para chegar até aqui, saíram do meio do mato para tentar ajudar a humanidade. Foi o que eu fiz para proteger meu povo na época.");
        Capitulo_4_D.Add("Malev – Linda, agora você tem acesso ao controle dos amotines. Salve a todos.");
        Capitulo_4_D.Add("Raposa (Melinda) – Linda, termine com isso.");
        Capitulo_4_D.Add("Linda (Com apenas um golpe, Linda mata Malev)");
        Capitulo_4_D.Add("Malev (Suspiro final) -...");
        Capitulo_4_D.Add("Coruja (Jones) – Terminamos por aqui. Malev não será mais um problema. Agora, só falta restaurar os amotines.");
        Capitulo_4_D.Add("Raposa (Melinda) – Estão sendo restaurados agora.");
        Capitulo_4_D.Add("Linda – É isso? ");
        Capitulo_4_D.Add("Raposa (Melinda) – Acho que terminamos... Que jornada. ");
        Capitulo_4_D.Add("Coruja (Jones) - Perdemos Wing, mas conseguimos cumprir nosso dever.");
        Capitulo_4_D.Add("Raposa (Melinda) – Então, até a próxima Animals... ");

        return Capitulo_4_D;
    }


    public List<string> GetCapitulo_4_E()
    {
        Capitulo_4_E = new List<string>();

        Capitulo_4_E.Add("CAPÍTULO 4 (FINAL 4) – O CRIADOR, A LIFE E O DESTINO DA HUMANIDADE - ESCOLHA E - SEM OS DRONES MELINDA SOBREVIVE, WING E JONES MORREM, LINDA MORRE E MALEV É DESTRUÍDO. A LIFE É DESTRUÍDA MAS NÃO CONSEGUEM SALVAR A HUMANIDADE.");
        //Cenário: Edifício da LIFE.
        Capitulo_4_E.Add("Raposa (Melinda) – Chegamos.");
        Capitulo_4_E.Add("Malev – Animals... Finalmente posso conhecê-los pessoalmente...");
        Capitulo_4_E.Add("Cão (Yael) – Linda conseguiu cumprir a missão dela.");
        Capitulo_4_E.Add("Malev – Ela serviu a esse país como uma heroína. Fez o que pôde para salvar o SOV de invasores...");
        Capitulo_4_E.Add("Raposa (Melinda) – Malev, você vai pagar pelo que fez a meu pai, aos Animals, a toda humanidade... Você não merece continuar a viver...");
        Capitulo_4_E.Add("Cão (Yael) – Chega de mais palavras Malev, você deve morrer.");
        Capitulo_4_E.Add("Raposa (Melinda) (Golpeia Malev em seu coração)");
        Capitulo_4_E.Add("Malev – Ahhh... você... você sabe bem o que está fazendo.");
        Capitulo_4_E.Add("Malev – Eu sei que não fui o melhor, mas sei que dei o meu melhor para salvar a todos de algo ainda pior: eles mesmos.");
        Capitulo_4_E.Add("Malev – Eu dei a vida eterna, livre do mal... seguros... E agora terão a morte digna.");
        Capitulo_4_E.Add("Raposa (Melinda) – O que quer dizer com isso?");
        Capitulo_4_E.Add("Malev – Eu desliguei os amotines assim que descobri que Linda tinha sido destruída. Isso significa que toda a humanidade foi destruída. ");
        Capitulo_4_E.Add("Cão (Yael) (Assustado e surpreso) – O quê??!!! Você matou todos!!");
        Capitulo_4_E.Add("Malev (Últimos suspiros) – Acabou Animals... Acabou Melinda e Cão...");
        Capitulo_4_E.Add("Raposa (Melinda) – Seu maldito... você... você conseguiu o que queria, mas a que custo? Seu psicopata! Eu não sou humana, mas minhas atitudes são mais humanas que as suas!");
        Capitulo_4_E.Add("Malev – Vocês podem dar um jeito nisso...");
        Capitulo_4_E.Add("Cão (Yael) – Há uma salvação?");
        Capitulo_4_E.Add("Malev – Sim...");
        Capitulo_4_E.Add("Cão (Yael) – Qual?");
        Capitulo_4_E.Add("Malev – Vocês devem se reproduzir, como uma nova espécie... Apenas assim teremos a continuidade do que foi a humanidade, em uma espécie fortalecida... Com tudo para serem uma civilização melhor e maior..., Mas isso não é eu quem decido.");
        Capitulo_4_E.Add("Malev – Adeus...");
        Capitulo_4_E.Add("Malev –...");


        return Capitulo_4_E;
    }


    public List<string> GetCapitulo_5_Creditos()
    {
        Capitulo_5_Creditos = new List<string>();

        //Cenário: créditos

        Capitulo_5_Creditos.Add("Muito obrigado por jogar! Sem você não conseguiríamos! Foram quase 2 anos" +
            " escrevendo o roteiro até desenvolver todos os personagens, a ideia em si. E depois decidi " +
            "reconstruir o jogo inteiro e melhorado na engine Unity o que me gerou mais alguns meses de estudo e de muito trabalho.");
        Capitulo_5_Creditos.Add("Você pode continuar apoiando a Saphire Game Studio " +
            "nos seguindo no instagram e vendo as novidades no nosso site, nos apoiando no Patreon, " +
            "nos enviando donates (doações) e é claro, jogando sempre os nossos jogos!");

        Capitulo_5_Creditos.Add("Agradecimentos especiais a:");
        Capitulo_5_Creditos.Add("Franciele Rocha (Tatinha) & Vitor");
        Capitulo_5_Creditos.Add("Mari Rocha");
        Capitulo_5_Creditos.Add("Luan Pereira");
        Capitulo_5_Creditos.Add("Italo Lopes");
        Capitulo_5_Creditos.Add("Luisa Lopes");
        Capitulo_5_Creditos.Add("Lucas Debone");
        Capitulo_5_Creditos.Add("Santos Reis");

        Capitulo_5_Creditos.Add("Desenvolvedores: (Primeira versão entre na Universidade, demo do Renpy) " +
            "Game Designer/roteirista/artista: Gabriel Rocha, Programador: Lucas Debone, Artista/sonoplasta: Santos Reis ");

        Capitulo_5_Creditos.Add("Desenvolvedores: (Unity, versão final)");
        Capitulo_5_Creditos.Add("Gabriel Rocha: Programador Unity (C#), UI Designer, Roteirista e Artista.");

        Capitulo_5_Creditos.Add("Softwares utilizados:");
        Capitulo_5_Creditos.Add("Visual Studio, VS Code, .net SDK, Unity Engine, Krita, Photoshop e Premiere!.");

        Capitulo_5_Creditos.Add("Siga-nos no instagram:");
        Capitulo_5_Creditos.Add("@Saphire_game_studio.");


        Capitulo_5_Creditos.Add("Obrigado por tudo!");


        return Capitulo_5_Creditos;
    }







}
