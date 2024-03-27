using UnityEngine;

public class Aiming : MonoBehaviour
{
    public Camera CameraLink;
    public Animator Anim;
    public float ToAimSpeed=1;

    private float NormalRotSpeed;
    public float AimingRotSpeed;

    public float AimingSpeed;
    private float NormalSpeed;
    private void Start()
    {
        NormalRotSpeed = GetComponent<CameraRotation>().RotationSpeed;
        NormalSpeed = GetComponent<PlayerController>().Speed;
    }
    void Update()
    {
        Aimingupdate();
    }
    private void Aimingupdate()
    {
        if (Input.GetMouseButton(1))
        {
            CameraLink.fieldOfView = Mathf.Max(30, CameraLink.fieldOfView - ToAimSpeed);
            GetComponent<CameraRotation>().RotationSpeed = AimingRotSpeed;
            GetComponent<PlayerController>().Speed = AimingSpeed;
            Anim.SetBool("IsAiming", true);
        }
        else
        {
            CameraLink.fieldOfView = Mathf.Min(45, CameraLink.fieldOfView + ToAimSpeed);
            GetComponent<CameraRotation>().RotationSpeed = NormalRotSpeed;
            GetComponent<PlayerController>().Speed = NormalSpeed;
            Anim.SetBool("IsAiming", false);
        }
    }
}
