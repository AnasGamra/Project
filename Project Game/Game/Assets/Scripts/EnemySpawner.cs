using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2, 1);
    }

    public void SpawnEnemy()
    {
        int index = Random.Range(0, 6);
        Instantiate(enemies[index], new Vector3(Random.Range(minX, maxX), transform.position.y, 0),Quaternion.identity);
    }


}
