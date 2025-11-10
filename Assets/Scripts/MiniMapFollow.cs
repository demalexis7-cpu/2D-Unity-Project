using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    public Transform player; // Playerul pe care îl urmăm

    void LateUpdate()
    {
        Vector3 newPos = player.position;
        newPos.z = transform.position.z; // păstrează distanța camerei față de scenă
        transform.position = newPos;
    }
}
