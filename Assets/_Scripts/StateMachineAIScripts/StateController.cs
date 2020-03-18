using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{

    public State currentState;
    public GameObject[] navPoints;
    public int navPointNum;
    public float remainingDistance;
    public Transform destination;
    public UnityStandardAssets.Characters.ThirdPerson.AICharacterControl ai;
    public Renderer[] childrenRend;

    public GameObject player;

    bool seePlayer = false;

    public Transform GetNextNavPoint()
    {
        navPointNum = (navPointNum + 1) % navPoints.Length;
        return navPoints[navPointNum].transform;
    }

    public void ChangeColor(Color color)
    {
        foreach(Renderer r in childrenRend)
        {
            foreach(Material m in r.materials)
            {
                m.color = color;
            }
        }
    }

    void findNavPoint()
    {
        navPoints = GameObject.FindGameObjectsWithTag("NavPoint");
        ai = GetComponent<UnityStandardAssets.Characters.ThirdPerson.AICharacterControl>();
        childrenRend = GetComponentsInChildren<Renderer>();
    }

   public void checkPlayerDistance()
    {
        float distToPlayer = Vector3.Distance(gameObject.transform.position, player.transform.position);
        //Debug.Log(distToPlayer);

        if (distToPlayer <= 50.0f)
        {
            seePlayer = true;
        }
        else
        {
            seePlayer = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        findNavPoint();

        SetState(new PatrolState(this));


    }

    // Update is called once per frame
    void Update()
    {
        currentState.CheckTransitions();
        currentState.Act();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            findNavPoint();
            SetState(new PatrolState(this));
        }
        else if (seePlayer)
        {
            SetState(new ChaseState(this));           
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            SetState(new WanderState(this));
        }


    }

    public void SetState(State state)
    {
        if(currentState != null)
        {
            currentState.OnStateExit();
        }
        currentState = state;
        gameObject.name = "AI agent in state " + state.GetType().Name;
        if(currentState != null)
        {
            currentState.OnStateEnter();
        }
    }

}
