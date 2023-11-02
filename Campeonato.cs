class Campeonato
{
    //atributos

    public string nomeCampeonato;
    public Equipe equipeParticipante1;
    public Equipe equipeParticipante2;


    //metodos

    public void iniciarPartida(Equipe equipe1, Equipe equipe2)
    {
        equipe1.PrimeiroJogador.Jogar();
        equipe1.SegundoJogador.Jogar();
        equipe1.TerceiroJogador.Jogar();
        equipe1.QuartoJogador.Jogar();
        equipe1.QuintoJogador.Jogar();

        equipe2.PrimeiroJogador.Jogar();
        equipe2.SegundoJogador.Jogar();
        equipe2.TerceiroJogador.Jogar();
        equipe2.QuartoJogador.Jogar();
        equipe2.QuintoJogador.Jogar();

    }

    public void Classificacao()
    {
        int pontuacaoEquipe1 = equipeParticipante1.PontosTotal();
        int pontuacaoEquipe2 = equipeParticipante2.PontosTotal();


        if (pontuacaoEquipe1 > pontuacaoEquipe2)
        {
            Console.WriteLine($"1º lugar: {equipeParticipante1.nomeEquipe} - Pontuação: {pontuacaoEquipe1}");
            Console.WriteLine($"2º lugar: {equipeParticipante2.nomeEquipe} - Pontuação: {pontuacaoEquipe2}");
        }
        else if (pontuacaoEquipe1 < pontuacaoEquipe2)
        {
            Console.WriteLine($"1º lugar: {equipeParticipante2.nomeEquipe} - Pontuação: {pontuacaoEquipe2}");
            Console.WriteLine($"2º lugar: {equipeParticipante1.nomeEquipe} - Pontuação: {pontuacaoEquipe1}");
        }
        else
        {
            Console.WriteLine($"Empate: {equipeParticipante1.nomeEquipe} e {equipeParticipante2.nomeEquipe} - Pontuação: {pontuacaoEquipe1}");
        }
    }


}
