using UnityEngine;

public class Aiming : MonoBehaviour
{
    public Camera CameraLink;
    public Animator Anim;
    public float AimSpeed=1;
    void Update()
    {
        Aimingupdate();
    }
    private void Aimingupdate()
    {
        if (Input.GetMouseButton(1))
        {
            CameraLink.fieldOfView = Mathf.Max(30, CameraLink.fieldOfView - AimSpeed);
            Anim.SetBool("IsAiming", true);
        }
        else
        {
            CameraLink.fieldOfView = Mathf.Min(45, CameraLink.fieldOfView + AimSpeed);
            Anim.SetBool("IsAiming", false);
        }
    }
}
