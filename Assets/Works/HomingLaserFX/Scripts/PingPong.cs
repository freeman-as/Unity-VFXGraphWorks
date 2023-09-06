using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    [SerializeField]
    private Transform _t;
    private float _elapsedTime;

    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        _t.position = new Vector3((Mathf.Sin(_elapsedTime*2f)*3f), _t.position.y, _t.position.z);
    }
}
