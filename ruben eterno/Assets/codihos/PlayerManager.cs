using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    private MovimentoPlayer movimentoPlayer;
    public float velocidadeDaAnimacao = 1;
    
    private Personagem personagem;
    
    
    void Start()
    {
        movimentoPlayer = GetComponent<MovimentoPlayer>();
        personagem = GetComponent<Personagem>();
    }
   void Update()
    {
      animator.SetBool("Andando", movimentoPlayer.Andando);
      animator.speed = velocidadeDaAnimacao;

      if (Input.GetKeyDown(KeyCode.Space))
      {
          animator.SetTrigger("Ataque");  
      }

      if (personagem.Energia() <= 0)
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
      }

    }
}