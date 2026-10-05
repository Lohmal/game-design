using UnityEngine;

public class Patroller : MonoBehaviour
{
    [SerializeField] private Transform pointB;
    [SerializeField] private float speed = 2.0f;
    private Vector3 pointA;
    private bool goingToB = true;
    void Start()
    {
        pointA = transform.position;
    }
    void Update()
    {
        Vector3 target = goingToB ? pointB.position : pointA;
        Vector3 p = transform.position; // 1. take a copy
        p.y = 2f; // 2. change the copy
        transform.position = p;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position == target)
        {
            goingToB = !goingToB;
            Debug.Log(name + " turns around");
        }
    }
}
