using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_target);
    }
}
