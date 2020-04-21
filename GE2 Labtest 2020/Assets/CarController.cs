using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject predator;
    void Start()
    {
        GetComponent<StateMachine>().ChangeState(new GreenIsGoState());
    }
}

class GreenIsGoState : State
{
    public override void Enter()
    {
        
    }

    public override void Think()
    {
       
    }

    public override void Exit()
    {
        
    }
}


/*
class PatrolState : State
{
    public override void Enter()
    {
       owner.GetComponent<FollowPath>().enabled = true;
    }

    public override void Think()
    {
        if (Vector3.Distance(
            owner.GetComponent<PreyController>().predator.transform.position,
            owner.transform.position) < 10)
        {
            owner.ChangeState(new DefendState());
        }
    }

    public override void Exit()
    {
        owner.GetComponent<FollowPath>().enabled = false;
    }
}

public class DefendState : State
{
    public override void Enter()
    {
        owner.GetComponent<Pursue>().target = owner.GetComponent<PreyController>().predator.GetComponent<Boid>();
        owner.GetComponent<Pursue>().enabled = true;
    }

    public override void Think()
    {
        if (Vector3.Distance(
            owner.GetComponent<PreyController>().predator.transform.position,
            owner.transform.position) > 30)
        {
            owner.ChangeState(new PatrolState());
        }
    }

    public override void Exit()
    {
        owner.GetComponent<Pursue>().enabled = false;
    }
}
*/
