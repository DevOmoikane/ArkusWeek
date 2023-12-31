using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour {
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 6f;

    private SpriteRenderer _spriteRenderer;

    private Vector2 _startSize;

    private void Start() {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }

    private void Update() {
        float delta = _speed * Time.deltaTime;
        Score.instance.IncrementDistance(delta);
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + delta, _spriteRenderer.size.y);
        if (_spriteRenderer.size.x > _width) {
            _spriteRenderer.size = _startSize;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        GameManager.instance.GameOver();
    }
}
