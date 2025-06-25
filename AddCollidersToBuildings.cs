using UnityEngine;

public class AddCollidersToBuildings : MonoBehaviour
{
    void Start()
    {
        // Find all generated buildings
        GameObject[] buildings = GameObject.FindGameObjectsWithTag("Building");

        foreach (GameObject building in buildings)
        {
            if (!building.GetComponent<Collider>())
            {
                BoxCollider collider = building.AddComponent<BoxCollider>();
                collider.center = Vector3.zero;
                collider.size = building.GetComponent<Renderer>().bounds.size;
            }
        }
    }
}
