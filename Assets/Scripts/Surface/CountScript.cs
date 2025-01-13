using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScript : MonoBehaviour
{
    public static Text ScoreText;
    [SerializeField] internal int _score = 0;

    void Start()
    {
        ScoreText = GetComponent<Text>();
        EventManager.PickedUp += OnPickedUp;
    }

    public void OnPickedUp()
    {
        _score++;
        ScoreText.text = _score.ToString();
    }
}
