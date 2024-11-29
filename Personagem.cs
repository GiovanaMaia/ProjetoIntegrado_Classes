using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class Personagem : MonoBehaviour
{

    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    // Construtor para inicializar o personagem
    public Personagem(string nome, int idade, string posicao)
    {
        Nome = nome;
        Idade = idade;
        Posicao = posicao;
    }

    // Método para obter as informações do personagem em formato de string
    public string ObterInformacoes()
    {
        return "Nome: " + Nome + "\nIdade: " + Idade + " anos" + "\nPosição: " + Posicao + " herdeira do trono de Aigam";
    }


}


