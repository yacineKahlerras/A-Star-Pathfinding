using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossTargetSetter : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
        }
    }
}
