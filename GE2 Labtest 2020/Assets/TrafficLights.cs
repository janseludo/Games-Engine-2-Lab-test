using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLights : MonoBehaviour
{
    public int numTrafficlights = 8;
    public float radius = 10;
    public float scale = 10;
    public List<GameObject> trafficLights = new List<GameObject>();

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

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.SetPositionAndRotation(pos, quat);
            cube.transform.parent = this.transform;
            cube.GetComponent<Renderer>().material.color = Color.HSVToRGB(
                i / (float)numTrafficlights, 1, 1);
            trafficLights.Add(cube);
        }

    }


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < trafficLights.Count; i++)
        {
            trafficLights[i].transform.localScale = new Vector3(1, 1 , 1);
        }
    }
}
