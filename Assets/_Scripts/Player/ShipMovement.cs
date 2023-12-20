
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    private Vector3 worldPoint;
    
    private void Start()
    {
    }

    private void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0;

        Vector3 newPos = Vector3.Lerp(transform.position, worldPoint, moveSpeed);
        transform.position = newPos;
    }

}
