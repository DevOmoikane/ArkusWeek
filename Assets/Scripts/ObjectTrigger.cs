using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour {

    [SerializeField] private GameObject _animationOnTriggerEnter;
    [SerializeField] private float _energyAmount;
    [SerializeField] private float _healthAmount;
    [SerializeField] private float _moneyAmount;

    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.CompareTag("Player")) {
            if (_energyAmount != 0) {
                Score.instance.UpdateEnergy(_energyAmount);
            }
            if (_healthAmount != 0) {
                Score.instance.UpdateHealth(_healthAmount);
            }
            if (_moneyAmount != 0) { 
                Score.instance.UpdateMoney(_moneyAmount);
            }
            if (_animationOnTriggerEnter!= null)
            {
                Instantiate(_animationOnTriggerEnter, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
