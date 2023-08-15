using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour {

    [SerializeField] private GameObject _animationOnTriggerEnter;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            if (_animationOnTriggerEnter!= null)
            {
                Instantiate(_animationOnTriggerEnter, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
