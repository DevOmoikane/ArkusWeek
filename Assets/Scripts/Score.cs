using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour {
    public static Score instance;

    [SerializeField] private TextMeshProUGUI _currentDistanceText;

    private int _currentDistance;
    private int _currentEnergy;
    private int _currentHealth;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    private void Start() {
        if (_currentDistanceText != null) {
            _currentDistanceText.text = _currentDistance.ToString();
        }
    }

}
