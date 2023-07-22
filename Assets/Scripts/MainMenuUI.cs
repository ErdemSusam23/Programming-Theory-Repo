using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI usernameText;
    [SerializeField] TextMeshProUGUI playerHealth;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] PlayerController playerController;

    private void Start()
    {
        SetUsername();
    }
    private void Update()
    {
        SetHealth();
        SetScore();
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
}
