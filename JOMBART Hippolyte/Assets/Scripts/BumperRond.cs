using System;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] private int strength = 300;
    private void OnCollisionEnter(Collision other)
    { 
        Vector3 a = transform.position;
        Vector3 b = other.transform.position;
        Vector3 direction = b - a;
        direction = direction.normalized;
        
        other.rigidbody.AddForce(direction * strength);
    }
}