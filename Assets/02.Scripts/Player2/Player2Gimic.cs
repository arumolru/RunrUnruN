using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Gimic : MonoBehaviour
{
    public int allCount;
    public int coin2Count = 0;
    public int stageLevel;
    private new AudioSource audio;
    public GameObject exitPortal;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PLAYER2COIN"))
        {
            coin2Count++;
            audio.Play();
        }

        else if (other.gameObject.CompareTag("PLAYER2FINISH") && allCount == coin2Count)
        {
            gameObject.SetActive(false);
        }

        else if (other.gameObject.CompareTag("FALL") || other.gameObject.CompareTag("OBSTACLE"))
        {
            SceneManager.LoadScene("Stage" + stageLevel.ToString());
        }

        else if (other.gameObject.CompareTag("PORTAL"))
        {
            transform.position = exitPortal.transform.position;
        }
    }
}
