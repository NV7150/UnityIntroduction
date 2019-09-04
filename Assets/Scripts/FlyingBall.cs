using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyingBall : MonoBehaviour {
    [SerializeField] private Text _text;
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start() {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(transform.right * -1000f + transform.up * 500f);
    }

    // Update is called once per frame
    void Update(){
    }
}