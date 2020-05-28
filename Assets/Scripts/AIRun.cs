using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AIRun : MonoBehaviour
{
    public Transform CurrentPosition;
    public Transform[] TargetPosition;
    public float speed = 1.0f;
    private int count;

    private void Update()
    {
        CurrentPosition.position = Vector3.MoveTowards(CurrentPosition.position, TargetPosition[count].position, speed * Time.deltaTime);
        CurrentPosition.rotation = Quaternion.RotateTowards(CurrentPosition.rotation, TargetPosition[count].rotation, 5 * Time.deltaTime);
        if (CurrentPosition.position == TargetPosition[count].position)
            count++;
    }
}
