using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        SceneManager.LoadScene("Scene1");
    }

}
