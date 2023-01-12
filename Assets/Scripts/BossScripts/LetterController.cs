using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterController : MonoBehaviour
{
    public float speed = 15f;
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
