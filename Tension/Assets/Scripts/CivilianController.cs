using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilianController : MonoBehaviour
{
    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rig.AddForce(Random.insideUnitSphere* 10);
    }
}
