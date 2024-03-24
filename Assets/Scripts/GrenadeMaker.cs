using UnityEngine;

public class GrenadeMaker : MonoBehaviour
{
    public GameObject Grenate;
    public float Range;
    public float Force;
    public float Damage;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) SpawnGrenade();
    }
    private void SpawnGrenade()
    {
        Grenate.GetComponent<Grenade>().Damage = Damage;
        var spawnedObject = Instantiate(Grenate);
        spawnedObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        var spawnedObjectRigidbody = spawnedObject.GetComponent<Rigidbody>();
        spawnedObjectRigidbody.AddForce(transform.forward * Force, ForceMode.Impulse);
        spawnedObjectRigidbody.AddTorque(transform.forward * Force, ForceMode.Impulse);
    }
}
