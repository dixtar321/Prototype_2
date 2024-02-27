using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _horizontalInput;
    private float _playerSpeed = 15.0f;

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalInput * _playerSpeed * Time.deltaTime);
    }
}
