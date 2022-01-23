using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ScoreManager : MonoBehaviour
{
	public static event Action<int> onScoreChanged;

	[SerializeField]
	int _score;


	private void OnEnable()
	{
		Balloon.onBalloonClick += IncreaseScore;
	}


	private void OnDisable()
	{
		Balloon.onBalloonClick -= IncreaseScore;
	}


	void IncreaseScore(int amount)
	{
		_score += amount;
		onScoreChanged?.Invoke(_score);
	}
}
