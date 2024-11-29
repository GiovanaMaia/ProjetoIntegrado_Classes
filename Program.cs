using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class canvaScript : MonoBehaviour
{
    public Text infoText;

    public void Start()
    {

        Personagem personagem = new Personagem("Ella Aigam", 17, "3°");

        // Salvando informações no PlayerPrefs
        PlayerPrefs.SetString("Nome", personagem.Nome);
        PlayerPrefs.SetInt("Idade", personagem.Idade);
        PlayerPrefs.SetString("Posicao", personagem.Posicao);
        PlayerPrefs.Save();

        // Recuperando as informações do PlayerPrefs
        string nome = PlayerPrefs.GetString("Nome", "Desconhecido");
        int idade = PlayerPrefs.GetInt("Idade", 0);
        string posicao = PlayerPrefs.GetString("Posicao", "N");

        // Exibindo as informações no Text UI
        infoText.text = $"Nome: {nome}\nIdade: {idade} anos\nPosição: {posicao} herdeira do trono de Aigam";
    }
    public void LoadScenes(string cena)
    {
        SceneManager.LoadScene(cena);
    }