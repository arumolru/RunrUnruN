using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageClearButton : MonoBehaviour
{
    public int stageLevel;
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Stage" + stageLevel + 1.ToString());
    }
}
