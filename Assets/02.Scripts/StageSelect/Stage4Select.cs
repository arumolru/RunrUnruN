using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage4Select : MonoBehaviour
{
    public void OnButtonClick()
    {
        StartCoroutine(Stage1Selected(1.1f));
    }

    IEnumerator Stage1Selected(float delay)
    {
        yield return new WaitForSeconds(delay);

        SceneManager.LoadScene("Stage1111");
    }
}
