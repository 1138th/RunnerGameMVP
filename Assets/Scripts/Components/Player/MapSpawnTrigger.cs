using UnityEngine;

public class MapSpawnTrigger : MonoBehaviour
{
    [SerializeField] public GameObject mapSpawnPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnAheadTrigger"))
        {
            Instantiate(mapSpawnPrefab, new Vector3(other.transform.parent.position.x, 0, 87), Quaternion.identity);
        }
    }
}