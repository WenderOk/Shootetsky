using UnityEngine;

public class PIGrotation : MonoBehaviour
{
    public Vector3 RotSpeed;
    void Update() { transform.rotation *= Quaternion.Euler(RotSpeed); }
}
