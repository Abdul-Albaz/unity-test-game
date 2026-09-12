using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public GameObject postProcessing;
  

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0f, v);
        transform.Translate(move * speed * Time.deltaTime, Space.World);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Post")
        {
            postProcessing.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Post")
        {
            postProcessing.SetActive(true);
        }
    }

  
}