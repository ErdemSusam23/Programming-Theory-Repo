using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public TMP_InputField inputField;

    public string userName;

    public int bestScore {  get; private set; }

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

    public void GetUsername()
    {
        userName = inputField.text;
    }




}
