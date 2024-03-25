using UnityEngine;

public class GrenadeMaker : MonoBehaviour
{
    public GameObject Grenate;
    public Transform Grenader;
    public float Range;
    public float Force;
    public float Damage=50;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) SpawnGrenade();
    }
    private void SpawnGrenade()
    {
        Grenate.GetComponent<Grenade>().Damage = Damage;
        var spawnedObject = Instantiate(Grenate);
        spawnedObject.transform.position = new Vector3(Grenader.position.x, Grenader.position.y, Grenader.position.z);

        var spawnedObjectRigidbody = spawnedObject.GetComponent<Rigidbody>();
        spawnedObjectRigidbody.AddForce(transform.forward * Force, ForceMode.Impulse);
        spawnedObjectRigidbody.AddTorque(transform.forward * Force, ForceMode.Impulse);
    }
}
