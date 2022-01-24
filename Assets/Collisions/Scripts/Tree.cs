using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tree : MonoBehaviour
{
	[SerializeField]
	MeshRenderer _mr;
	[SerializeField]
	Color _hitColor;


	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			_mr.material.color = _hitColor;
		}
	}
}
