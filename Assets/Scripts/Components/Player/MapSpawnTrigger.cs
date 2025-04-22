using UnityEngine;

public class MapSpawnTrigger : MonoBehaviour
{
    [SerializeField] public GameObject mapSpawnPrefab1;

    private const float ZSpawnPointAhead = 87;
    private const float XSpawnPointLeft = -65;
    private const float XSpawnPointRight = 65;
    private readonly int[] _xSpawnPointsAhead = { -50, -25, 0, 25, 50 };
    private readonly int[] _zSpawnPointsLeftRight = { 25, 50, 75 };

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnAheadTrigger"))
        {
            foreach (var xDelta in _xSpawnPointsAhead)
            {
                GameObject mapTile = Instantiate(
                    mapSpawnPrefab1,
                    new Vector3(other.transform.parent.position.x + xDelta, 0, ZSpawnPointAhead),
                    Quaternion.identity);
        
                mapTile.SetActive(true);
            }
        }

        if (other.CompareTag("SpawnLeftTrigger") && Input.GetKey(KeyCode.A))
        {
            foreach (var zDelta in _zSpawnPointsLeftRight)
            {
                GameObject mapTile = Instantiate(
                    mapSpawnPrefab1,
                    new Vector3(XSpawnPointLeft, 0, zDelta),
                    Quaternion.identity);
        
                mapTile.SetActive(true);
            }
        }

        if (other.CompareTag("SpawnRightTrigger") && Input.GetKey(KeyCode.D))
        {
            foreach (var zDelta in _zSpawnPointsLeftRight)
            {
                GameObject mapTile = Instantiate(
                    mapSpawnPrefab1,
                    new Vector3(XSpawnPointRight, 0, zDelta),
                    Quaternion.identity);
        
                mapTile.SetActive(true);
            }
        }
    }
}