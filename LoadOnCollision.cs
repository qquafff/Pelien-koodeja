using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnCollision : MonoBehaviour
{
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ground")
        {
            SceneManager.LoadScene(0);
        }
    }
}