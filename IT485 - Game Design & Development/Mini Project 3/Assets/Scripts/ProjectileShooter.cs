using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public float theVelocity = 10;
    public IVelocity aVelocity = new FastVelocity();
    private Camera _camera;
    private void OnGUI()
    {
        int size = 12;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }

    public void SetThrowingVelocity(IVelocity aNewVelocity)
    {
        this.aVelocity = aNewVelocity;
    }
    public GameObject dodgeball;
    GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        theVelocity = aVelocity.ThrowVelocity();
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(dodgeball) as GameObject;
            projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * theVelocity;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.SetThrowingVelocity(new FastVelocity());
        }else if (Input.GetKeyDown(KeyCode.B))
        {
            this.SetThrowingVelocity(new SlowVelocity());
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            this.SetThrowingVelocity(new MediumVelocity());
        }


    }
}
