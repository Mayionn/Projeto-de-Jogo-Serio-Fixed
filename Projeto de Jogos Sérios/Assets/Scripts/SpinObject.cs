using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour {

    public float speed = 10f;

    public void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
