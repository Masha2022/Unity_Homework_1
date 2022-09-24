using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] public float Speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Move(0, Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Move(0, -Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Move(Speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Move(-Speed * Time.deltaTime, 0);
        }
    }

    public void Move(float deltaX, float deltaZ)
    {
        var position = transform.position;
        position.x = Mathf.Clamp(position.x + deltaX, -80, 80);
        position.z += deltaZ;
        transform.position = position;
    }
}