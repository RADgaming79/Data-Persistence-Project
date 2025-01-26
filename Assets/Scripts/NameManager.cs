using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class NameManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static NameManager Instance;

    public TextMeshProUGUI field;
    public string playerName;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            playerName = field.text;
        }
    }
}