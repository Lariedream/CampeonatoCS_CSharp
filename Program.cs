Jogador jogador1 = new Jogador();
jogador1.nome = "Diego Buerno";
jogador1.nickname = "DiegoKml";

Jogador jogador2 = new Jogador();
jogador2.nome = "Larissa";
jogador2.nickname = "Cenouriita";

Jogador jogador3 = new Jogador();
jogador3.nome = "Gabriel";
jogador3.nickname = "Gabrieljknd";

Jogador jogador4 = new Jogador();
jogador4.nome = "Andrew";
jogador4.nickname = "lHenryzera";

Jogador jogador5 = new Jogador();
jogador5.nome = "João";
jogador5.nickname = "Psycholovers";

Jogador jogador6 = new Jogador();
jogador6.nome = "Pedro";
jogador6.nickname = "Gatio de Botas";

Jogador jogador7 = new Jogador();
jogador7.nome = "Bruno";
jogador7.nickname = "Pinho";

Jogador jogador8 = new Jogador();
jogador8.nome = "Ane";
jogador8.nickname = "Heda";

Jogador jogador9 = new Jogador();
jogador9.nome = "Victor";
jogador9.nickname = "Wandão";

Jogador jogador10 = new Jogador();
jogador10.nome = "Gabriel";
jogador10.nickname = "Fox";

//criando equipe 1
Equipe equipe1 = new Equipe();
equipe1.nomeEquipe = "Letolandia";


//atribuindo jogador na equipe 1
equipe1.AdicionarJogador(jogador1);
equipe1.AdicionarJogador(jogador2);
equipe1.AdicionarJogador(jogador3);
equipe1.AdicionarJogador(jogador4);
equipe1.AdicionarJogador(jogador5);

//criando equipe 2
Equipe equipe2 = new Equipe();
equipe2.nomeEquipe = "Zumbilandia";


//atribuindo jogador na equipe 2
equipe2.AdicionarJogador(jogador6);
equipe2.AdicionarJogador(jogador7);
equipe2.AdicionarJogador(jogador8);
equipe2.AdicionarJogador(jogador9);
equipe2.AdicionarJogador(jogador10);

//campeonato

Campeonato campeonato = new Campeonato();
campeonato.nomeCampeonato= "LigaCS";
campeonato.equipeParticipante1 = equipe1;
campeonato.equipeParticipante2 = equipe2;

Console.WriteLine($"Vai começar o campeonato {campeonato.nomeCampeonato}!");


Console.WriteLine($"-------------------------------------------------------");

Console.WriteLine($"Hoje teremos o time {equipe1.nomeEquipe} que enfrentara o time {equipe2.nomeEquipe}!");
Console.WriteLine($"Time {equipe1.nomeEquipe} composto pelos jogadores: ");
Console.WriteLine($"");
Console.WriteLine($"{equipe1.PrimeiroJogador.nickname} \n{equipe1.SegundoJogador.nickname} \n{equipe1.TerceiroJogador.nickname} \n{equipe1.QuartoJogador.nickname}\n{equipe1.QuintoJogador.nickname}");
Console.WriteLine($"");
Console.WriteLine($"");
Console.WriteLine($"Ja o time {equipe2.nomeEquipe} composto pelos jogadores: ");
Console.WriteLine($"");
Console.WriteLine($"{equipe2.PrimeiroJogador.nickname} \n{equipe2.SegundoJogador.nickname} \n{equipe2.TerceiroJogador.nickname} \n{equipe2.QuartoJogador.nickname}\n{equipe2.QuintoJogador.nickname}");

Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine($"");


Console.WriteLine("O jogo começou, para quem é sua torcida? Faça suas apostas.");
Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine($"");

campeonato.iniciarPartida(equipe1, equipe2);

Console.WriteLine("Jogo em andamento");
Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine($"");

Console.WriteLine("Ja temos um time vencedor !! Abaixo nossa classificação");

Console.WriteLine($"");
campeonato.Classificacao();

