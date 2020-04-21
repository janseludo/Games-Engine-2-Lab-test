using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject GreenIsGo;
    void Start()
    {
        GetComponent<StateMachine>().ChangeState(new GreenIsGoState());
    }
}

class GreenIsGoState : State
{
    public Transform goGreen;
    public Arrive arrive;
    public override void Enter()
    {
        arrive = owner.GetComponent<Arrive>();
    }

    public override void Think()
    {
        
        Vector3 target = goGreen.transform.position;
        target.y = 0;
        arrive.targetPosition = target;

        if (Vector3.Distance(owner.transform.position, goGreen.transform.position) < 1)
        {
            
        }
    }

    public override void Exit()
    {
        
    }
}
