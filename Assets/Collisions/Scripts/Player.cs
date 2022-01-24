using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField]
	float _moveForce;
	[SerializeField]
	Rigidbody _rig;


	void FixedUpdate()
	{
		float xInput = Input.GetAxis("Horizontal");

		_rig.AddForce(Vector3.right * xInput * _moveForce);
	}
}
