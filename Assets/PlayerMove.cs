using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    public float movementSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {   
        rb = GetComponent<Rigidbody>();
    
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 Velocity = rb.velocity;
        if(Input.GetKey("left"))
        {
            Vector3 eulerAngles = transform.rotation.eulerAngles;
            eulerAngles.y = eulerAngles.y + -0.5f; 
            transform.rotation = Quaternion.Euler(eulerAngles);
        }
        if(Input.GetKey("right"))
        {
            Vector3 eulerAngles = transform.rotation.eulerAngles;
            eulerAngles.y = eulerAngles.y + 0.5f; 
            transform.rotation = Quaternion.Euler(eulerAngles);
        }
        if(Input.GetKey("up"))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        if(Input.GetKey("down"))
        {
           transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(1);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
