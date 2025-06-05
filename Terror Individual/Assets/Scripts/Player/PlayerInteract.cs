using UnityEngine;

public class PlayerInteract : MonoBehaviour, IInteraction
{
    Transform rayCastOrigin;
    [SerializeField] float distance;
    IInteraction target;

    public void Hit()
    {
        
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(rayCastOrigin.position, rayCastOrigin.forward *10 , Color.cyan);
        if (Input.GetButtonDown("Fire1"))
        {
           target?.Hit();
        }
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(rayCastOrigin.position, rayCastOrigin.forward, out RaycastHit hit, distance))
        {
            if(hit.collider.TryGetComponent(out IInteraction target))
            {
                this.target = target;
               
            }
            else
            {
                this.target = null; 
            }
        }
        else
        {
            this.target = null;
        }


    }
    
    public void MonsterCollison(Collider col)
    {
        if (col.gameObject.GetComponent<Monster>() != null)
        {
            print("Acertou o Monstro");
        }
    }
}
