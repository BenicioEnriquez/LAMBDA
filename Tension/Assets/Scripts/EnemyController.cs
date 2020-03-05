using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public GameObject target;
    public GameObject deadEnemy;
    [Range(0,100)]
    public float health = 100.0f;
    private NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            nav.destination = target.transform.position;
        }
        catch { }

        if (health <= 0)
        {
            Instantiate(deadEnemy, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Robot")
        {
            collision.gameObject.GetComponent<RobotController>().health -= 10;
        }
    }
}
