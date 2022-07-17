using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMove1 : MonoBehaviour
{
    public float pipeSpeed;
    

    void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
    }
}
