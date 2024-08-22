using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForBigEnemy : MonoBehaviour
{
    private float RotateSpeed = 300;

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, RotateSpeed * Time.deltaTime); 
    }
}
