using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject _spawnPrefab;
    [SerializeField]
    int _spawnCount = 5;
    [SerializeField]
    float _spawnOffset = 1.5f;


    void Start()
    {
        if (_spawnPrefab != null)
        {
            SpawnEnemies();
        }
        else
		{
            Debug.LogError("Cannot spawn enemies - prefab is missing!");
		}
    }


    void Update()
    {
        
    }


    void SpawnEnemies()
	{

	}
}
