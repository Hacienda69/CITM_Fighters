using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    Animator _animator;

    float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _speed = Mathf.Sin(Time.time) * 5 + 5;
        _animator.SetFloat("Speed", _speed);

        if (Input.GetKeyDown(KeyCode.Space))
            _animator.SetLayerWeight(1, 1);
    }
}
