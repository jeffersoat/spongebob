using UnityEngine;
public class Move_player : MonoBehaviour
{
    Vector3 pos;

    void Start()
    {
        pos=transform.position;
    }
    // Update is called once per frame
    void Update()
    {
       float x_move=Input.GetAxis("Horizontal");
       float z_move=Input.GetAxis("Vertical"); 
       pos.x+=x_move*Time.deltaTime;
       pos.z+=z_move*Time.deltaTime;
       transform.position=pos;
        
    }
}
