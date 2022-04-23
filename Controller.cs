using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTargetLocation : MonoBehaviour
{
    public Camera nonVRCamera;
    public GameObject Character;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left mouse clicked");
            RaycastHit hit;
            Ray ray = nonVRCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "floor")
                {
                    Instantiate(Character, hit.point, Quaternion.identity);
                    print("My object is clicked by mouse");
                }
            }
        }
    }
}
