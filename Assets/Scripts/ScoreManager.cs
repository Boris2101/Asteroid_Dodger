using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] Text scoreDisplay;
    [SerializeField] int scoreForDescent;
    [SerializeField] Animator buttonAnimator;

    private void Awake()
    {
        score = PlayerPrefs.GetInt("SavedMainSceneScore");
    }
    private void Update()
    {
        scoreDisplay.text = score.ToString();
        StartButtonAnim();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Asteroid"))
        {
            score++;
            PlayerPrefs.SetInt("SavedMainSceneScore", score);
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
