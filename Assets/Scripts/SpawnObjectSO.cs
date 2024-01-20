using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnObject", menuName = "ScriptableObjects/SpawnObject", order = 1)]
public class SpawnObjectSO : ScriptableObject {
    public GameObject spawnObject;
    public GameObject afterEffect;
    public float deltaEnergy;
    public float deltaHealth;
    public float deltaMoney;
}
