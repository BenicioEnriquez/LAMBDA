using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadCamController : MonoBehaviour
{
    public GameObject middle;

    void Update()
    {
        transform.position = middle.transform.position + new Vector3(0, 3, 0);
    }
}
