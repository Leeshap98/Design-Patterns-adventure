using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _speed = 3f;

    private void Update()
    {
       float horizontalAxis  = Input.GetAxisRaw("Horizontal");
       float verticalAxis  = Input.GetAxisRaw("Vertical");

        Vector3 diraction = new Vector3(horizontalAxis, 0, verticalAxis).normalized * _speed * Time.deltaTime;

        transform.position += diraction ;
    }
}
