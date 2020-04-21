using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public string color;
    public Material green;
    public Material yellow;
    public Material red;
    public Material yellow2;

    void Awake()
    {

        int color = Random.Range(0, 3);
        if (color == 0) { StartCoroutine("Green"); }
        if (color == 1) { StartCoroutine("Yellow"); }
        if (color == 2) { StartCoroutine("Red"); }
        if (color == 3) { StartCoroutine("Yello2"); }

    }
    IEnumerator Green()
    {
        gameObject.GetComponent<MeshRenderer>().material = green;
        color = "green";
        int wait = Random.Range(5, 11);
        yield return new WaitForSeconds(wait);
        StartCoroutine("Yellow");
    }
    IEnumerator Yellow()
    {
        gameObject.GetComponent<MeshRenderer>().material = yellow;
        color = "yellow";
        yield return new WaitForSeconds(4);
        StartCoroutine("Green");
    }
    IEnumerator Red()
    {
        gameObject.GetComponent<MeshRenderer>().material = yellow;
        color = "red";
        yield return new WaitForSeconds(4);
        StartCoroutine("Yellow");
    }

    IEnumerator Yellow2() //orange
    {
        gameObject.GetComponent<MeshRenderer>().material = green;
        color = "green";
        int wait = Random.Range(5, 11);
        yield return new WaitForSeconds(wait);
        StartCoroutine("Green");
    }

}
