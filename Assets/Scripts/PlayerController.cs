using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    public Animator Amin;

    private float _fallVelocity = 0;
    private Vector3 _moveVector;

    public float Gravity = 9.8f;
    public float JumpForce;
    public float Speed;
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (_moveVector != Vector3.zero) Amin.SetBool("IsWalk", true);
        else Amin.SetBool("IsWalk", false);

        _moveVector = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) _moveVector += transform.forward;
        if (Input.GetKey(KeyCode.S)) _moveVector -= transform.forward;
        if (Input.GetKey(KeyCode.D)) _moveVector += transform.right;
        if (Input.GetKey(KeyCode.A)) _moveVector -= transform.right;


        if (Input.GetKeyDown(KeyCode.Space)&&_characterController.isGrounded)
        {
            _fallVelocity = -JumpForce;
            Amin.SetBool("IsGrounded", false);
        }
    }
    void FixedUpdate()
    {
        _characterController.Move(_moveVector * Speed * Time.fixedDeltaTime);

        _fallVelocity += Gravity * Time.fixedDeltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);

        if(_characterController.isGrounded)
        {
            _fallVelocity = 0;
            Amin.SetBool("IsGrounded", true);
        }
    }
}
