using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeicalGimic : MonoBehaviour
{
    public float delayTime = 1.0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("PLAYER") || collision.gameObject.CompareTag("PLAYER2"))
        {
            StartCoroutine(DeleteGround(1.0f));
        }
    }

    IEnumerator DeleteGround(float delay)
    {
        yield return new WaitForSeconds(delay);

        gameObject.SetActive(false);
    }
}
