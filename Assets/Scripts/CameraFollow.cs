using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform subject;
    [SerializeField] float cameraSmoothFollow;

    private void LateUpdate()
    {
        Vector3 followVector = new Vector3(subject.position.x, transform.position.y, subject.position.z);

        Vector3 smoothFollowVector = Vector3.Lerp(transform.position, followVector, cameraSmoothFollow * Time.deltaTime);

        transform.position = smoothFollowVector;
    }

}
