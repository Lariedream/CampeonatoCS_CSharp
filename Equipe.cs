class Equipe
{
    //atributos
    public string nomeEquipe;

    public Jogador PrimeiroJogador;
    public Jogador SegundoJogador;
    public Jogador TerceiroJogador;
    public Jogador QuartoJogador;
    public Jogador QuintoJogador;


    //metodos
    public int PontosTotal()
    {
        int pontosTotal = 0;
        pontosTotal += (PrimeiroJogador != null) ? PrimeiroJogador.getPontos() : 0;
        pontosTotal += (SegundoJogador != null) ? SegundoJogador.getPontos() : 0;
        pontosTotal += (TerceiroJogador != null) ? TerceiroJogador.getPontos() : 0;
        pontosTotal += (QuartoJogador != null) ? QuartoJogador.getPontos() : 0;
        pontosTotal += (QuintoJogador != null) ? QuintoJogador.getPontos() : 0;
        return pontosTotal;
    }
    public void AdicionarJogador(Jogador jogador)
    {
        if (PrimeiroJogador == null)
        {
            PrimeiroJogador = jogador;
        }
        else if (SegundoJogador == null)
        {
            SegundoJogador = jogador;
        }
        else if (TerceiroJogador == null)
        {
            TerceiroJogador = jogador;
        }
        else if (QuartoJogador == null)
        {
            QuartoJogador = jogador;
        }
        else if (QuintoJogador == null)
        {
            QuintoJogador = jogador;
        }
        else
        {
            Console.WriteLine("A equipe já possui 5 jogadores. Não é possível adicionar mais.");
        }
    }
}

