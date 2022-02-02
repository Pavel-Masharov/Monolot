using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMoving : MonoBehaviour
{
    private readonly float _speedCircle = 2f;
    private readonly float _maxDistance = 3f;
    private void OnEnable()
    {
        StartCoroutine(MoveCircle());
    }

    void Update()
    {
        if(transform.position.x >= _maxDistance)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator MoveCircle()
    {

        while (true)
        {
            transform.position += Vector3.right * Time.deltaTime * _speedCircle;
            yield return null;
        }
    }


}

