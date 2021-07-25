using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private BoxCollider playerCollider;
    [SerializeField] private Vector3 movementSpeed;


    private void Update()
    {
		transform.Translate( movementSpeed * Time.deltaTime);
    }
}
