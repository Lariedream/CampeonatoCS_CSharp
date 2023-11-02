class Jogador
{
    //atributos

    public string nome;
    public string nickname;
    public int pontos;


    //metodo

    public void Jogar()
    {
        Random rnd = new Random();
        int pontuacao = rnd.Next(1,101);
        pontos += pontuacao;

    }
    //GET E SET?
    public int getPontos()
    {
        return pontos;
    }
}