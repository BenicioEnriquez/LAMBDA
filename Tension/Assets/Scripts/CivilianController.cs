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
        if (Time.frameCount % 300 == 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 360 * Random.value));
            rig.AddRelativeForce(Vector3.forward * Random.value * 1000);
        }
    }
}
