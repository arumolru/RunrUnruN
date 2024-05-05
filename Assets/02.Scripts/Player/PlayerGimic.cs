using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGimic : MonoBehaviour
{
    public int allCount;
    public int coinCount = 0;
    public int stageLevel;
    private new AudioSource audio;
    public GameObject exitPortal;

    private bool isJump;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PLAYERCOIN"))
        {
            coinCount++;
            audio.Play();
        }

        else if (other.gameObject.CompareTag("PLAYERFINISH") && allCount == coinCount)
        {
            gameObject.SetActive(false);
        }

        else if(other.gameObject.CompareTag("FALL") || other.gameObject.CompareTag("OBSTACLE"))
        {
            SceneManager.LoadScene("Stage" + stageLevel.ToString());
        }

        else if(other.gameObject.CompareTag("PORTAL"))
        {
            transform.position = exitPortal.transform.position;
        }
    }
}
