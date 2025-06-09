using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    private MovimentoPlayer movimentoPlayer;
    public float velocidadeDaAnimacao = 1;
    
    void Start()
    {
        movimentoPlayer = GetComponent<MovimentoPlayer>();
    }
   void Update()
    {
      animator.SetBool("Andando", movimentoPlayer.andando);
      animator.speed = velocidadeDaAnimacao;
    }
}