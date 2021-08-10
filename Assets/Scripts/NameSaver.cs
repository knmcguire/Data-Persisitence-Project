using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NameSaver : MonoBehaviour
{
    public static NameSaver Instance;
    public string PlayerName;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}