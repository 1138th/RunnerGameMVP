using UnityEngine;

public class MoveMap : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            MoveMapTo(Vector3.left);
        }

        if (Input.GetKey(KeyCode.A))
        {
            MoveMapTo(Vector3.right);
        }
        MoveMapTo(Vector3.back);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MapDestroyTrigger"))
        {
            Destroy(gameObject);
        }
    }

    private void MoveMapTo(Vector3 direction)
    {
        transform.position += direction * (15 * Time.deltaTime);
    }
}