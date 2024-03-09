using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    public Animator Anim;

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
        MovementUpdate();
        JumpUpdate();
    }

    private void JumpUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _characterController.isGrounded)
        {
            _fallVelocity = -JumpForce;
            Anim.SetBool("IsGrounded", false);
        }
    }

    private void MovementUpdate()
    {
        _moveVector = Vector3.zero;
        Anim.SetInteger("Direction", 0);

        if (Input.GetKey(KeyCode.W))
        {
            _moveVector += transform.forward;
            Anim.SetInteger("Direction", 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _moveVector -= transform.forward;
            Anim.SetInteger("Direction", -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _moveVector += transform.right;
            Anim.SetInteger("Direction", 2);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _moveVector -= transform.right;
            Anim.SetInteger("Direction", -2);
        }
    }

    void FixedUpdate()
    {
        JumpFixedUpdate();
    }

    private void JumpFixedUpdate()
    {
        _characterController.Move(_moveVector * Speed * Time.fixedDeltaTime);

        _fallVelocity += Gravity * Time.fixedDeltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);

        if (_characterController.isGrounded)
        {
            _fallVelocity = 0;
            Anim.SetBool("IsGrounded", true);
        }
    }
}
