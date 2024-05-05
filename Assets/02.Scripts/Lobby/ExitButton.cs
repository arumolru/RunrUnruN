using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    private new AudioSource audio;

    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public void OnButtonClick()
    {
        audio.Play();

        StartCoroutine(GameExitTime(1.2f));
    }

    IEnumerator GameExitTime(float delay)
    {
        yield return new WaitForSeconds(delay);

        Application.Quit();
    }
}
