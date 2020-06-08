using UnityEngine;

public class PlayerTrack : MonoBehaviour
{
    public Transform player;
    public Vector3 disp;
    
    void Update()
    {
        transform.position = player.position + disp;      
    }
}
