using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScript : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    [SerializeField] int _score = 0;
    
    void Start()
    {
        _scoreText = GetComponent<Text>();
        EventMagager.PickedUp += OnPickedUp;
    }

    public void OnPickedUp()
    {
        _score++;
        _scoreText.text = _score.ToString();
    }
}
