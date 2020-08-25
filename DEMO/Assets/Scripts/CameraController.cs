using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;  // 单例模式/instance
    public float speed;
    public Transform target; // target position

    private void Awake()
    {
        instance = this;
    }




    void Update()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.position.x, target.position.y, transform.position.z), speed * Time.deltaTime);
        }
        // time correct
    }

    public void ChangeTarget(Transform newTarget)//  this method will be called when detect the door/room.
    {
        target = newTarget;

    }
}
