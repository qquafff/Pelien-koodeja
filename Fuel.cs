using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Jetpack");
    }

    float jetpackCooldown = 3f;

    void Update()
    {
        if (Input.GetKey("right"))
        {
            jetpackCooldown -= Time.deltaTime;
            Debug.Log(jetpackCooldown);

            if (jetpackCooldown <= 0)
            {
                Debug.Log("end");

                jetpackCooldown = 3f;
                gameObject.SetActive(false);
            }
        }
    }
}