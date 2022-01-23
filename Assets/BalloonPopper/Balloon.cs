using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Balloon : MonoBehaviour
{
	[SerializeField]
	int _scoreToGive = 1;
	[SerializeField]
	int _clicksToPop = 5;
	[SerializeField]
	float _scaleIncreasePerClick = 0.1f;


	void OnMouseDown()
	{
		_clicksToPop--;

		transform.localScale += Vector3.one * _scaleIncreasePerClick;
	}
}
