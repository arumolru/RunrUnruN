using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class LobbyGameManager : MonoBehaviour
{
    public GameObject gameTitle;
    public float delayTime = 3.0f;

    void Awake()
    {
        gameTitle.SetActive(false);
    }

    void Start()
    {
        Invoke("StartTitle", delayTime);
#if UNITY_EDITOR
        PlayerPrefs.DeleteKey("Stage1Cleared");
        PlayerPrefs.DeleteKey("Stage2Cleared");
        PlayerPrefs.DeleteKey("Stage3Cleared");
        PlayerPrefs.DeleteKey("Stage4Cleared");
        PlayerPrefs.DeleteKey("Stage5Cleared");
        PlayerPrefs.Save();
#endif
    }

    void StartTitle()
    {
        gameTitle.SetActive(true);
    }
}
