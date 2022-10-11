using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repairSpawner : MonoBehaviour
{

    float _xMin;
    float _xMax;
    float _ySpawn;

    [SerializeField] GameObject _repairKit;


    // Start is called before the first frame update
    void Start()
    {
        _xMin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        _xMax = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        _ySpawn = Camera.main.ViewportToWorldPoint(new Vector3(0, 1.2f, 0)).y;

        InvokeRepeating("spawnRepairKit", 0, 15f);
    }

    void spawnRepairKit()
    {
        float randX = Random.Range(_xMin, _xMax);
        Instantiate(_repairKit, new Vector3(randX, _ySpawn, 0), Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
