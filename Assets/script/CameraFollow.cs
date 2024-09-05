using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // Update is called once per frame
    void Update()
    {
         Vector3 newPosition = thingToFollow.transform.position;
    newPosition.z = transform.position.z; // Pertahankan posisi z kamera asli
    transform.position = newPosition;
    }
}
