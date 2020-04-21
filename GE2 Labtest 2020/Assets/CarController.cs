using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Transform lights;
    public List<GameObject> trafficLight = new List<GameObject>();
    public float speed = 5.0f;
    public bool greenLight = false;
    void Start()
    {
        GreenIsGoState();
    }
    void GreenIsGoState()
    {
        greenLight = false;
        trafficLight.Clear();
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("TrafficLights"))
        {
            if (item.GetComponent<Lights>().color == "green")
            {
                trafficLight.Add(item);
            }
        }
        int next = Random.Range(0, trafficLight.Count);
        lights = trafficLight[next].transform;
        greenLight = true;

    }
    void Update()
    {
        if (lights.GetComponent<Lights>().color == "green" && lights != null)
        {
            float move = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, lights.position, move);
            transform.LookAt(lights.position);
            if (Vector3.Distance(transform.position, lights.position) < 0.01f)
            {
                if (greenLight == true)
                {
                    GreenIsGoState();
                }
            }
        }
        else
        {
            if (greenLight == true)
            {
                GreenIsGoState();
            }

        }

    }
}