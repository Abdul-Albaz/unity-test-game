using UnityEngine;

public class movePalyer : MonoBehaviour
{
    public float playerSpeed=1;
   
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(Horizontal,0, Vertical);
        transform.Translate(move*Time.deltaTime* playerSpeed);
        
    }
}
