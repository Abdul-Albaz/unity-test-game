using System.Collections;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int playerHealth = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 99)
        {
            StartCoroutine(Heal());
        }

    }

    public void takedamge()
    {

    }

    IEnumerator Heal()
    {
        Debug.Log("Hi");
        yield return new WaitForSeconds(4);
        Debug.Log("Coroutine");
    }
}
