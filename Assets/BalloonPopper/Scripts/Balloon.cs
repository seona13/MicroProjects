using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Balloon : MonoBehaviour
{
	public static event Action<int> onBalloonClick;

	[SerializeField]
	int _scoreToGive = 1;
	[SerializeField]
	int _clicksToPop = 5;
	[SerializeField]
	float _scaleIncreasePerClick = 0.1f;


	void OnMouseDown()
	{
		transform.localScale += Vector3.one * _scaleIncreasePerClick;

		_clicksToPop--;
		if (_clicksToPop == 0)
		{
			onBalloonClick?.Invoke(_scoreToGive);
			Destroy(gameObject);
		}
	}
}
