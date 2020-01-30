using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform.position);
        rig.AddRelativeForce(Vector3.forward * speed);
    }
}
