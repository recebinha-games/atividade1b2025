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
        Vector3 posi��o = transform.position;

        if (Input.GetKey(KeyCode.A)){posi��o.x = posi��o.x - Rapidez * Time.deltaTime;
            Debug.Log("A");}

        if (Input.GetKey(KeyCode.D)){posi��o.x = posi��o.x + Rapidez * Time.deltaTime;
            Debug.Log("D");}

        if (Input.GetKey(KeyCode.S))
        {
            posi��o.z = posi��o.z - Rapidez * Time.deltaTime;
            Debug.Log("S"); }
        
        if (Input.GetKey(KeyCode.W))
        {
            posi��o.z = posi��o.z + Rapidez * Time.deltaTime;
            Debug.Log("W"); }
     
        transform.position = posi��o;
     
    }

}