using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BowlingBall : MonoBehaviour
{
	[SerializeField]
	float _forwardForce;
	[SerializeField]
	float _leftBorder;
	[SerializeField]
	float _rightBorder;
	[SerializeField]
	float _moveIncrement;
	[SerializeField]
	Rigidbody _rig;


	public void Bowl()
	{
		_rig.AddForce(transform.forward * _forwardForce, ForceMode.Impulse);
	}
}
