using System.Collections;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CountDown());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator CountDown()
    {
        Debug.Log("Start");
        yield return new WaitForSeconds(2);
        Debug.Log("2 Sec Passed");
    }
}
