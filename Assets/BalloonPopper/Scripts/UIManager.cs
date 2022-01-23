using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _score;


	void OnEnable()
	{
        ScoreManager.onScoreChanged += UpdateScore;
	}


	void OnDisable()
	{
        ScoreManager.onScoreChanged -= UpdateScore;
	}


	void Start()
    {
        UpdateScore(0);
    }


    void UpdateScore(int amount)
	{
        _score.text = amount.ToString();
	}
}
