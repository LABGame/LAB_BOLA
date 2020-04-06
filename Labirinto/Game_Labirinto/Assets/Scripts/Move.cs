using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    private Rigidbody Bola;
 
    void Start()
    {
        //Bola = gameObject.AddComponent<Rigidbody>();
        //Bola.mass = 1.0f;
        //Physics.gravity = new Vector3(0, -10f, 0);
        //Bola.drag = -0.1f;
        //Bola.angularDrag = 0f;
        Bola.velocity = new Vector3(10.0f,0, 10.0f);

    }

    void Update()
    {
        //Bola.WakeUp();

    }
}