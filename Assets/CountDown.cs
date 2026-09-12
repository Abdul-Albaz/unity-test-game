using System.Collections;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CountDownTest());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator CountDownTest()
    {
        Debug.Log("Time Start");
        yield return new WaitForSeconds(3f);

        Debug.Log("3 Sec passed");

    }
}
