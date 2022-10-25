using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    // Скрипт управлением gameObject
    void Start()
    {
        /*Debug.Log(gameObject.name);
        Debug.Log(gameObject.scene);
        Debug.Log(gameObject.tag);*/

        /*transform.position = new Vector3(1, 4, 0);
        transform.eulerAngles = new Vector3(0, 45, 30);
        transform.localScale = new Vector3(1, 2, 8);*/
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 0.4f);            
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -0.4f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale *= 1.8f;
        }

        transform.eulerAngles = new Vector3(Input.mousePosition.x, 0, 0);
    }

}
