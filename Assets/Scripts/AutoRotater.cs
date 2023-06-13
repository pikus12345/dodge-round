using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotater : MonoBehaviour
{
    public float moveSpeed;
    private void FixedUpdate()
    {
        transform.Rotate(0,0,moveSpeed * Time.fixedDeltaTime);
    }
}
