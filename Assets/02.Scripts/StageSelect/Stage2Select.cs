using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage2Select : MonoBehaviour
{
    public void OnButtonClick()
    {
        StartCoroutine(Stage2Selected(1.1f));
    }

    IEnumerator Stage2Selected(float delay)
    {
        yield return new WaitForSeconds(delay);

        SceneManager.LoadScene("Stage11");
    }
}
