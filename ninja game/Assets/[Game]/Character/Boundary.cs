using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public float xMin, xMax;

    void Update()
    {
        float x = Mathf.Clamp(transform.position.x, xMin, xMax);

        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}