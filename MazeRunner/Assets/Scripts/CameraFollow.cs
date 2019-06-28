using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothing = 2f;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;

    }

    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
       float mouseX = (Input.mousePosition.x / Screen.width) - 0.5f;
     //float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
      transform.localRotation = Quaternion.Euler(new Vector4(-1f * (0 * 180f), mouseX * 360f, transform.localRotation.z));
    }
}
