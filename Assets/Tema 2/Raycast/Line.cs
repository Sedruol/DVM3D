using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    private LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.enabled = true;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position + Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
