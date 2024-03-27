using UnityEngine;

public class GrenadeMaker : MonoBehaviour
{
    public float CoulDown;
    private float CurrentCoulDown;
    public GameObject Grenate;
    public Transform Grenader;
    public float Range;
    public float Force;
    public float Damage=50;
    void Update()
    {
        CurrentCoulDown = Mathf.Max(0, CurrentCoulDown - 0.1f);
        if (Input.GetKeyDown(KeyCode.G)&& CurrentCoulDown <= 0) SpawnGrenade();
    }
    private void SpawnGrenade()
    {
        CurrentCoulDown = CoulDown;
        Grenate.GetComponent<Grenade>().Damage = Damage;
        var spawnedObject = Instantiate(Grenate);
        spawnedObject.transform.position = new Vector3(Grenader.position.x, Grenader.position.y, Grenader.position.z);

        var spawnedObjectRigidbody = spawnedObject.GetComponent<Rigidbody>();
        spawnedObjectRigidbody.AddForce(transform.forward * Force, ForceMode.Impulse);
        spawnedObjectRigidbody.AddTorque(transform.forward * Force, ForceMode.Impulse);
    }
}
