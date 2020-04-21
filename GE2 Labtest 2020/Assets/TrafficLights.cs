using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLights : MonoBehaviour
{
    public int numTrafficlights = 12;
    public float radius = 10;
    
    public List<GameObject> trafficLights = new List<GameObject>();

    Color[] colors = new Color[3];
    float timer = 4.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {

        MakeTrafficLights();
    }

    void MakeTrafficLights()
    {

        trafficLights.Clear();
        float theta = (Mathf.PI * 2.0f) / numTrafficlights;
        for (int i = 0; i < numTrafficlights; i++)
        {
            Vector3 pos = new Vector3(Mathf.Sin(theta * i) * radius, 0, Mathf.Cos(theta * i) * radius
                );
            pos = transform.TransformPoint(pos);
            Quaternion quat = Quaternion.AngleAxis(theta * i * Mathf.Rad2Deg, Vector3.up);
            quat = transform.rotation * quat;

            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder.transform.SetPositionAndRotation(pos, quat);
            cylinder.transform.parent = this.transform;
            //start with random color (red, yellow, green and purple
            //loop to change every 4 seconds from red - yello - green
            colors[1] = cylinder.GetComponent<Renderer>().material.color = Color.red;
            colors[0] = cylinder.GetComponent<Renderer>().material.color = Color.green;
            colors[2] = cylinder.GetComponent<Renderer>().material.color = Color.yellow;

            cylinder.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
            trafficLights.Add(cylinder);
        }

    }

    void Update()
    {
        for (int i = 0; i < trafficLights.Count; i++)
        {
            trafficLights[i].transform.localScale = new Vector3(1, 1, 1);
        }
        
    }
}
