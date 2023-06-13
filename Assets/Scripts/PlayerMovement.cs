using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public RotationDirection direction;

    private void Update()
    {
        if (Input.anyKeyDown & GameManager.isGameRunning)
        {
            InvertCurrentDirection();
        }
    }
    public void InvertCurrentDirection()
    {
        direction = RotationDirectionUtilites.InvertRotationDirection(direction);
    }
    private void FixedUpdate()
    {
        if (GameManager.isGameRunning)
        {
            transform.Rotate(
            0,
            0,
            RotationDirectionUtilites.ConvertToInt(direction) * moveSpeed * Time.fixedDeltaTime
            );
        }
    }
}
