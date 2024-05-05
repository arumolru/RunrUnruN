using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage2Clear : MonoBehaviour
{
    public GameObject player;
    public GameObject player2;
    public GameObject clearUI;
    public GameObject backGroundSound;

    private void Update()
    {
        if (!player.activeSelf && !player2.activeSelf)
        {
            clearUI.SetActive(true);
            backGroundSound.SetActive(false);

            PlayerPrefs.SetInt("Stage2Cleared", 1);
            PlayerPrefs.Save();
        }
    }
}
