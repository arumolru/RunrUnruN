using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyGameStartButton : MonoBehaviour
{
    public float delayTime = 1.1f;

    public void OnButtonClick()
    {
        StartCoroutine(NextScene(1.1f));
    }

    IEnumerator NextScene(float delay)
    {
        yield return new WaitForSeconds(delay);

        SceneManager.LoadScene("StageSelect");
    }
}
