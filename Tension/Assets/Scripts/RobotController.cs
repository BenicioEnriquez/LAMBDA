using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    private Rigidbody rig;
    private GameObject head;

    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rig.AddRelativeForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rig.AddRelativeForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rig.AddRelativeForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rig.AddRelativeForce(Vector3.right * speed);
        }
    }
}
