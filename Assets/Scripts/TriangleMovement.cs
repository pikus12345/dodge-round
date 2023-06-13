using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMovement : MonoBehaviour
{
    public float moveSpeed;
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        Vector3 diff = Vector3.zero - transform.position;
        float rotateZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);
    }
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.zero, moveSpeed * Time.fixedDeltaTime);
    }
    private void Update()
    {
        if (!GameManager.isGameRunning)
        {
            animator.SetTrigger("Dissappear");
            moveSpeed = 0;
        }
        if (transform.position.Equals(Vector2.zero))
        {
            Destroy(gameObject);
        }
        
        
    }
}
