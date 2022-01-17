using System.Collections;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{

    [SerializeField] private GameObject prefab;

    private float minHeight = -1.7f;
    private float maxHeight = 2.3f;

    private void OnEnable()
    {
        StartCoroutine(Spawn());
    }

    private void OnDisable()
    {
        StopCoroutine(Spawn()); 
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            float spawnRepeatTime = Random.Range(1.5f, 4f);
            yield return new WaitForSeconds(spawnRepeatTime);
            Instantiate(prefab, new Vector3(3.4f, Random.Range(minHeight, maxHeight), 0f), Quaternion.identity);
        } 
    }
}