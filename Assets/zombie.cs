using UnityEngine;
using System.Collections;

public class zombie : MonoBehaviour {

    private UnityEngine.AI.NavMeshAgent agent;
    private Animator animator;
    private Transform player;
    public float HP = 10;

	// Use this for initialization
	void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(transform.position,player.position)>=2.5f)
        {
            //print(Vector3.Distance(transform.position, player.position));
            if (agent.enabled)
                agent.SetDestination(player.position);
            //agent.speed = 1;
        }
        else
        {
            //animator.SetBool("attack", true);
            animator.Play("attack");
            if (agent.enabled)
                agent.Stop();
        }
        //if(Input.GetKeyDown(KeyCode.L))
        //    TakeDamage();
        //print(Vector3.Distance(transform.position, player.position));
	
	}
    public void TakeDamage()
    {
        int damage = Random.Range(1, 4);
        HP -= 20;
        if(HP<=0)
        {
            GetComponent<CapsuleCollider>().enabled = false;
            animator.Play("fallingback");
            agent.Stop();
            agent.enabled = false;
            
            // agent.enabled = false;
            Destroy(gameObject, 2);
        }
    }
}
