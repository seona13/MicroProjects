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


	public void MoveLeft()
	{
		if (transform.position.x > _leftBorder)
		{
			transform.position += new Vector3(-_moveIncrement, 0, 0);
		}
	}


	public void MoveRight()
	{
		if (transform.position.x < _rightBorder)
		{
			transform.position += new Vector3(_moveIncrement, 0, 0);
		}
	}
}
