using UnityEngine;

public class InimigoManager : MonoBehaviour
{
    public Animator animator;
    private MovimentoInimigo movimentoInimigo;
    public float velocidadeDaAnimacao = 1;
    
    private Inimigo inimigo;
    
    void Start()
    {
        movimentoInimigo = GetComponent<MovimentoInimigo>();
        inimigo = GetComponent<Inimigo>();
    }
   void Update()
    {
      animator.SetBool("Andando", movimentoInimigo.andando);
      animator.speed = velocidadeDaAnimacao;

      if (movimentoInimigo.ataque == true)
      {
        animator.SetTrigger("Ataque");  
      }

      if (inimigo.Energia() <= 0)
      {
          gameObject.SetActive(false);
      }

    }
}