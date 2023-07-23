using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI usernameText;
    [SerializeField] TextMeshProUGUI playerHealth;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI wave;
    [SerializeField] PlayerController playerController;
    [SerializeField] GameManager gameManager;

    private void Start()
    {
        playerController =  FindAnyObjectByType<PlayerController>();
        gameManager = FindAnyObjectByType<GameManager>();

        SetUsername();
    }
    private void Update()
    {
        SetHealth();
        SetScore();
        ShowWaveNum();
    }
    private void SetUsername()
    {
        usernameText.text = MainManager.Instance.userName;
    }
    private void SetHealth()
    {
        playerHealth.text = "Health: " + playerController.healt;
    }
    private void SetScore() 
    {
        score.text = "Score: " + playerController.score;
    }

    private void ShowWaveNum() 
    {
        int waveNum = gameManager.waveNumber - 1;
        wave.text = "Wave: " + waveNum;
    }
}
