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
		for (int i = 0; i < _spawnCount; i++)
		{
            float xPos = i * _spawnOffset;
            Vector3 spawnPos = new Vector3(xPos, 0, 0);
            Instantiate(_spawnPrefab, spawnPos, Quaternion.identity);
		}
	}
}
