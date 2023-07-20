using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] public TMP_Text text;

    public TMP_InputField inputField;

    private void Start()
    {
        if (MainManager.Instance != null)
        {
            SetUsername();
        }
    }
    public void StartButton() 
    {
        SceneManager.LoadScene(1);
    }

    public void GetUsername() 
    {
        MainManager.Instance.userName = inputField.text;
        Debug.Log(MainManager.Instance.userName);
    }

    void SetUsername() 
    {
        text.text = MainManager.Instance.userName;
    }


}
