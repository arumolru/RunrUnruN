using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour
{
    public GameObject pauseUI;
    public void OnButtonClick()
    {
        pauseUI.SetActive(false);
    }
}
