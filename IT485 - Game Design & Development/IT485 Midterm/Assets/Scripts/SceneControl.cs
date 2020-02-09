using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{

    private void OnCollisionEnter(Collision col)
    {
        SceneManager.LoadScene("Scene 2");
    }

}
