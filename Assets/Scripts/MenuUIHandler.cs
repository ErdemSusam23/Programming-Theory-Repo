using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuUIHandler : MonoBehaviour
{
    public void StartButton() 
    {
        SceneManager.LoadScene(1);
    }
}
