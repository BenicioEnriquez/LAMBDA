using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    private Rigidbody rig;
    private GameObject head;
    private Vector2 camRotation;

    public float speed = 10f;
    public float cameraSensitivity;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        rig = GetComponent<Rigidbody>();
        head = this.gameObject.transform.GetChild(0).gameObject; //Gets the child game object
    }

    // Update is called once per frame
    void Update()
    {
        camRotation.x -= Input.GetAxis("Mouse Y") * cameraSensitivity;
        camRotation.y += Input.GetAxis("Mouse X") * cameraSensitivity;
        camRotation.x = Mathf.Clamp(camRotation.x, -60, 60);
        head.transform.eulerAngles = new Vector3(camRotation.x, camRotation.y, 0);
        transform.eulerAngles = new Vector3(0, camRotation.y, 0);

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
