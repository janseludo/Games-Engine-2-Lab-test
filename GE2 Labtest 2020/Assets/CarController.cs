using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject[] trafficLights;
    

    void Start()
    {
        GetComponent<StateMachine>().ChangeState(new GreenIsGoState());
    }
    void Update()
    {
        
    }
}

class GreenIsGoState : State
{
    public GameObject trafficLight;
    public Arrive arrive;


    public override void Enter()
    {
        
        
        
    }
    public override void Think()
    {
       
    }

    public override void Exit()
    {
        owner.GetComponent<Boid>().velocity = Vector3.zero;
        owner.GetComponent<Boid>().acceleration = Vector3.zero;
        arrive.enabled = false;
    }
}
