using System;
using Unity.VisualScripting;
using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{
    public GameObject ataqueObject;
    private GameObject _player;
    
    
    private Rigidbody _rigidbody;
    private float velocidade;

    public float raioDeVisao = 10;
    private bool naVisao = false;
    
    private SphereCollider _sphereCollider;

    public float distanciaMinima = 1.5f;
    
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        velocidade = gameObject.GetComponent<Inimigo>().Velocidade();
        _sphereCollider = gameObject.GetComponent<SphereCollider>();
        
        _player = GameObject.FindWithTag("Player");
    }

 
    void Update()
    {
        _sphereCollider.radius = raioDeVisao;

        if (Vector3.Distance(transform.position, _player.transform.position) > distanciaMinima)
        {
            if (naVisao == true)
            {
                transform.LookAt(_player.transform.position);
                transform.position = Vector3.MoveTowards(transform.position,
                    _player.transform.position,
                    velocidade * Time.deltaTime);
            }
            ataqueObject.SetActive(false);
        }
        else
        {
            ataqueObject.SetActive(true);
        }

        Debug.DrawLine(transform.position, _player.transform.position, Color.red);
        
    }
    void OnTriggerStay(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = true;
        }
        
    }

    private void OnTriggerExit(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            naVisao = false;
        }
    }
}
