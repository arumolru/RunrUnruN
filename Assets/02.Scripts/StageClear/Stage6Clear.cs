using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage6Clear : MonoBehaviour
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

            PlayerPrefs.SetInt("Stage6Cleared", 1);
            PlayerPrefs.Save();
        }
    }
}
