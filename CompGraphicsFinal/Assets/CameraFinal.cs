using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFinal : MonoBehaviour
{

    public GameObject player;
    public float MouseLookSens;
    private Vector3 offset;
    public float movespeed;

    private float X = 0;
    private float Y = 0;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = player.transform.position + offset;
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            offset = offset *1.1f;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) // forward
        {
            offset = offset / 1.1f;
        }
       /* if (Input.GetMouseButton(1))
        {
            X = X + Input.GetAxis("Mouse X") * MouseLookSens;
            Y = Y + Input.GetAxis("Mouse Y") * MouseLookSens;
            Y = Mathf.Clamp(Y, -90, 90);


            transform.localRotation = Quaternion.AngleAxis(X, Vector3.up);
            transform.localRotation = transform.localRotation * Quaternion.AngleAxis(Y, Vector3.left);
       
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * MouseLookSens, Vector3.up) * offset;
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);
        */
    }

    void LateUpdate()
    {
        
    }
    // Update is called once per frame , Guranted to run after all items have been processed

}
