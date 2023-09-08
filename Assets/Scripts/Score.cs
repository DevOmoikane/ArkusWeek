using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour {
    public static Score instance;

    [SerializeField] private TextMeshProUGUI _currentDistanceText;
    [SerializeField] private TextMeshProUGUI _currentMoneyText;
    [SerializeField] private float _initialEnergy = 0f;
    [SerializeField] private float _maxHealth = 100f;

    public float _currentDistance;
    public float _currentEnergy;
    public float _currentHealth;
    public float _currentMoney;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    private void Start() {
        if (_currentDistanceText != null) {
            _currentDistanceText.text = _currentDistance.ToString();
        }
        if (_currentMoneyText != null) {
            _currentMoneyText.text = "$" + _currentMoney.ToString();
        }
        ResetScore();
    }

    public void ResetScore() {
        _currentDistance = 0f;
        _currentEnergy = _initialEnergy;
        _currentHealth = _maxHealth;
        _currentMoney = 0f;
    }

    public void IncrementDistance(float delta) {
        _currentDistance += delta;
        if (_currentDistanceText != null) {
            _currentDistanceText.text = Mathf.FloorToInt(_currentDistance).ToString() + "m";
        }
    }

    public void UpdateHealth(float delta) {
        _currentHealth += delta;
    }

    public void UpdateEnergy(float delta) {
        _currentEnergy += delta;
    }

    public void UpdateMoney(float amount) {
        _currentMoney += amount;
        if (_currentMoneyText != null) {
            _currentMoneyText.text = _currentMoney.ToString("C2");
        }
    }

}
