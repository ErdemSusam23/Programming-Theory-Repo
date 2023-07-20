using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    private MainManager mainManager;

    public TMP_Text text;

    private void Start()
    {
        Debug.Log("Test");
        SetUserName();
    }

    public void StartButton() 
    {
        SceneManager.LoadScene(1);
    }

    void SetUserName() 
    {
        Debug.Log(mainManager.userName);
        text.text = mainManager.userName;
    }

}
