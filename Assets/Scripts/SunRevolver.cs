using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRevolver : MonoBehaviour
{
    float timeCounter = 0;

    float speed;
    float width;
    float height;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.1f;
        width= 50;
        height = 50;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) *width;
        float y = Mathf.Sin(timeCounter) * height;
        float z = 0;

        transform.localEulerAngles = new Vector3(x, y, z);

    }
}
