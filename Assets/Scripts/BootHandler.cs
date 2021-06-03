using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BootHandler : MonoBehaviour
{
    public static BootHandler Instance;
    [SerializeField] Button startButton;
    [SerializeField] TMP_InputField playerNameInput;
    public string playerName
    {
        get; private set;
    }

    private void Awake()
    {
        // Implement basic Singleton pattern for the static instance of this class
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        } else
        {
            Instance = this;
        }

        DontDestroyOnLoad(Instance);
        startButton.onClick.AddListener(StartClicked);
    }

    void StartClicked()
    {
        playerName = playerNameInput.text;
        SceneManager.LoadScene(1);
    }
}
