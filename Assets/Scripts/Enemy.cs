using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;

    private void Update()
    {
        transform.LookAt(target);
        Vector3 direction = target.position - transform.position;
        direction.y = 0;

        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}
