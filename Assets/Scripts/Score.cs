using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour {
    public static Score instance;

    [SerializeField] private TextMeshProUGUI _currentDistanceText;

    private float _currentDistance = 0f;
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

    public void ResetDistance() {
        _currentDistance = 0f;
    }

    public void UpdateDistance(float delta) {
        _currentDistance += delta;
    }

}
