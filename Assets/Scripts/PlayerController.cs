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

        _moveVector = Vector3.zero;
        Anim.SetFloat("speed", 0);
        Anim.SetFloat("LateralSpeed", 0);

        if (Input.GetKey(KeyCode.W))
        {
            _moveVector += transform.forward;
            Anim.SetFloat("speed", 1);
        }
        if (Input.GetKey(KeyCode.S))
        { 
            _moveVector -= transform.forward;
            Anim.SetFloat("speed", -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _moveVector += transform.right;
            Anim.SetFloat("LateralSpeed", 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _moveVector -= transform.right;
            Anim.SetFloat("LateralSpeed", -1);
        }


        if (Input.GetKeyDown(KeyCode.Space)&&_characterController.isGrounded)
        {
            _fallVelocity = -JumpForce;
            Anim.SetBool("IsGrounded", false);
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
            Anim.SetBool("IsGrounded", true);
        }
    }
}
