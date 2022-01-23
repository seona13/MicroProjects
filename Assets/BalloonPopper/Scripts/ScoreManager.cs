using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
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
	}
}
