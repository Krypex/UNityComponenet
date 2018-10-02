using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daimondscript : MonoBehaviour
{

    public SpriteRenderer rend;
    public Color newcolor;
    public Transform other;

    //transform.Rotate(0, 0, rotationSpeed* Time.deltaTime);
    //transform.Translate(5 * Time.deltaTime, 0, 0, Space.World);
    
    [Range(-720, 720)]
    public float rotationSpeed;
    // Use this for initialization
    void Start()
    {
        rend.color = newcolor;
        rend.color = new Color(1f, 0.5f, 0.3f);
        // other.position = new Vector3(3, 2, other.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
            

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);

        }
        transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);

    }  

}
