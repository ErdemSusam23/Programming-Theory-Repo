using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public TMP_InputField inputField;

    

    public string userName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SaveUsername()
    {
        userName = inputField.text;
        Debug.Log(userName);
    }

    void SetUserName() 
    {
        text.text = userName;
    }

}
