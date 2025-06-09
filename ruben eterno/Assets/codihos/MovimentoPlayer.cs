using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    private Rigidbody _rigidbody; 
    
    private float velocidade;

    public bool andando = false;
     void Start()
     {
         velocidade = gameObject.GetComponent<Personagem>().Velocidade();
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 posicao = transform.position;

        andando = false;
        
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 45, 0);
            andando =  true;
        }
        else
            
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 135, 0);
            andando =  true;
        }
        else    
        
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -135, 0);
            andando =  true;
        }
        else   
            
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -45, 0);
            andando =  true;
        }
        else   
            
        //esquerda X-
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, -90, 0);
            andando =  true;
        }
        else
        //direira  X+
        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 90, 0);
            andando =  true;
        }
        else
        //cima  Z+
        if (Input.GetKey(KeyCode.W))
        {
            posicao.z = posicao.z + velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            andando =  true;
        }
        else
        //baixo Z-
        if (Input.GetKey(KeyCode.S))
        {
            posicao.z = posicao.z - velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            andando =  true;
        }
        
        transform.position = posicao;
        
        

    }
}