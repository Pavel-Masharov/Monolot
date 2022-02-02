using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectController : MonoBehaviour
{
    [SerializeField] private CircleMoving _circlePrefab;
    private readonly Vector3 _posSpawnCircles = new Vector3 (-2.25f, 0, 0);

    public void StartSpawn()
    {
        StartCoroutine(CreateCircles());
    }

    IEnumerator CreateCircles()
    {
        while (true)
        {
            Instantiate(_circlePrefab, _posSpawnCircles, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }

    }

}
