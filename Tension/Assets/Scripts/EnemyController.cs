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
    private Animator anim;
    private Vector3 lastPosition;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
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

    void FixedUpdate()
    {
        //speed = Mathf.Lerp(speed, (transform.position - lastPosition).magnitude / Time.deltaTime, 0.75f);
        //lastPosition = transform.position;
        anim.SetFloat("Forward", 0.5f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Robot")
        {
            collision.gameObject.GetComponent<RobotController>().health -= 10;
        }
    }
}
