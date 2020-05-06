using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneTrigger : MonoBehaviour
{
    public bool active = false;
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("e"))
        {
            if (gameObject.name == "sub_area_1")
            {
                SceneManager.LoadScene("BallScene");
            }
            else if (gameObject.name == "sub_area_2")
            {
                SceneManager.LoadScene("CineMachineScene");
            }
        }
    }
}
