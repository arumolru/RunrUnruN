using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button stage2Button;
    public Button stage3Button;
    public Button stage4Button;
    public Button stage5Button;
    public Button stage6Button;

    private void Awake()
    {
        stage2Button.interactable = false;
        if (PlayerPrefs.GetInt("Stage1Cleared",0) == 1)
        {
            stage2Button.interactable = true;
        }
        stage3Button.interactable = false;
        if (PlayerPrefs.GetInt("Stage2Cleared", 0) == 1)
        {
            stage3Button.interactable = true;
        }
        stage4Button.interactable = false;
        if (PlayerPrefs.GetInt("Stage3Cleared", 0) == 1)
        {
            stage4Button.interactable = true;
        }
        stage5Button.interactable = false;
        if (PlayerPrefs.GetInt("Stage4Cleared", 0) == 1)
        {
            stage5Button.interactable = true;
        }
        stage6Button.interactable = false;
        if (PlayerPrefs.GetInt("Stage5Cleared", 0) == 1)
        {
            stage6Button.interactable = true;
        }
    }
}
