using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        SceneManager.LoadScene("Scene2");
    }

}