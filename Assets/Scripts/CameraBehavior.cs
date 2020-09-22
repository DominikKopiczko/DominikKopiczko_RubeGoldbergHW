using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject mainBall;
    public float speed = 7.0f;
    
    void Update () {
        float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, mainBall.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, mainBall.transform.position.x, interpolation);

        this.transform.position = position;
    }
}
