using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeMaker : MonoBehaviour
{
    public GameObject Grenate;
    public float Range;
    public float Force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) SpawnGrenade();
    }
    private void SpawnGrenade()
    {

        var spawnedObject = Instantiate(Grenate);
        spawnedObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        var spawnedObjectRigidbody = spawnedObject.GetComponent<Rigidbody>();
        spawnedObjectRigidbody.AddForce(transform.forward * Force, ForceMode.Impulse);
        spawnedObjectRigidbody.AddTorque(transform.forward * Force, ForceMode.Impulse);
    }
}
