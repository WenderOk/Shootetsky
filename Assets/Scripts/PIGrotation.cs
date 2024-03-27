using UnityEngine;

public class PIGrotation : MonoBehaviour
{
    public Vector3 RotSpeed;
    public Vector3 speed = new Vector3(0,2,0);
    public GameObject text;
    void Update() 
    {
        RotSpeed = new Vector3(Random.Range(1, 100), Random.Range(1, 100), Random.Range(1, 100));
        transform.rotation *= Quaternion.Euler(RotSpeed);
        text.transform.rotation *= Quaternion.Euler(speed);
    }
}
