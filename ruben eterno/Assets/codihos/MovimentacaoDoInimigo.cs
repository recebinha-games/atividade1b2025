using UnityEngine;

public class MovimentacaoDoInimigo : MonoBehaviour
{
    private GameObject _player;
    
    private Rigidbody _rigidbody;
    private float velocidade;

    public float raioDeVisao = 10;
    private bool naVisao = false;

    private SphereCollider _sphereCollider;
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        velocidade = gameObject.GetComponent<Inimigo>().Velocidade();
        _sphereCollider = gameObject.GetComponent<SphereCollider>();

        _player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        _sphereCollider.radius = raioDeVisao;


        if(naVisao == true){
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position,_player.transform.position,velocidade*Time.deltaTime);
        }

       
    }

    void OnTriggerStay(Collider other){
        if (other.gameObject.CompareTag("Player")){
            naVisao = true;
        }
    }
    
    void OnTriggerExit (Collider other){
        if (other.gameObject.CompareTag("Player")){
            naVisao = false;
        }
    }

}