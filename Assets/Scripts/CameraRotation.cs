using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float RotationSpeed;
    public Transform CameraAxisTransform;
    public float minAngle;
    public float maxAngle;

    void FixedUpdate()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.fixedDeltaTime * Input.GetAxis("Mouse X")*RotationSpeed, 0);

        var newAngleX = CameraAxisTransform.localEulerAngles.x - Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse Y");
        if (newAngleX > 180) newAngleX -= 360;
        newAngleX = Mathf.Clamp(newAngleX, minAngle, maxAngle);
        

        CameraAxisTransform.localEulerAngles = new Vector3(newAngleX,0, 0);
    }
}
