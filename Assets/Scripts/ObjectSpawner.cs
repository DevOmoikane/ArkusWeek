using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private float _groundPosition = -0.681f;
    [SerializeField] private float _probabilityGroundObjects = 20f;
    [SerializeField] private GameObject[] _floatingObjects;
    [SerializeField] private GameObject[] _groundObjects;

    private float _timer;

    private void Start() {
        SpawnObject();
    }

    private void Update() {
        if (_timer > _maxTime) {
            SpawnObject();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }

    private void SpawnObject() {
        GameObject newObject;
        if (Random.Range(0f, 100f) <= _probabilityGroundObjects)
        {
            Vector3 spawnPos = new Vector3(transform.position.x, _groundPosition, 0);
            GameObject randObject = _groundObjects[Random.Range(0, _groundObjects.Length)];
            newObject = Instantiate(randObject, spawnPos, Quaternion.identity);
        }
        else
        {
            Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
            GameObject randObject = _floatingObjects[Random.Range(0, _floatingObjects.Length)];
            newObject = Instantiate(randObject, spawnPos, Quaternion.identity);
        }
        Destroy(newObject, 10f);
    }
}
