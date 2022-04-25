using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform transformView;
    [SerializeField] private Transform thirdPerson;
    [SerializeField] private bool isFpsView = true;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isFpsView = !isFpsView;
        }
        transform.position = isFpsView ? transformView.position : thirdPerson.position;
    }
}
