using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;
       // transform.Translate(offset);
    }

    // Update is called once per frame
    void Update()
    {
          transform.position = target.position + offset;
       
       
      //  offset = transform.position - target.position;
      //  if (offset.magnitude > 0)
        //    transform.Translate(offset);
    }
}
