using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody _rigidbody;
    public int Rapidez;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posição = transform.position;

        if (Input.GetKey(KeyCode.A)){posição.x = posição.x - Rapidez * Time.deltaTime;
            Debug.Log("A");}

        if (Input.GetKey(KeyCode.D)){posição.x = posição.x + Rapidez * Time.deltaTime;
            Debug.Log("D");}

        if (Input.GetKey(KeyCode.S))
        {
            posição.z = posição.z - Rapidez * Time.deltaTime;
            Debug.Log("S"); }
        
        if (Input.GetKey(KeyCode.W))
        {
            posição.z = posição.z + Rapidez * Time.deltaTime;
            Debug.Log("W"); }
     
        transform.position = posição;
     
    }

}