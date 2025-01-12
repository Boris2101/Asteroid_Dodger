using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] int record = 0;
    [SerializeField] Text scoreDisplay;
    [SerializeField] Text recordDisplay;
    [SerializeField] int scoreForDescent;
    [SerializeField] Animator buttonAnimator;

    private void Awake()
    {
        score = 0;
        record = PlayerPrefs.GetInt("SavedMainSceneRecord");
    }
    private void Update()
    {
        scoreDisplay.text = "Ñ÷¸ò: " + score.ToString();
        recordDisplay.text = "Ðåêîðä: " + PlayerPrefs.GetInt("SavedMainSceneRecord").ToString();
        StartButtonAnim();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Asteroid"))
        {
            score++;
            PlayerPrefs.SetInt("SavedMainSceneScore", score);
            if (score > record)
            {
                record = score;
                PlayerPrefs.SetInt("SavedMainSceneRecord", record);
            }
            PlayerPrefs.Save();
        }
    }

    private void StartButtonAnim()
    {
        if (score >= scoreForDescent)
        {
            buttonAnimator.SetBool("Button1UpBegin", true);
            buttonAnimator.SetBool("Button1IsOnline", true);
        }
    }
}
