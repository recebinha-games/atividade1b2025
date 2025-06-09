using UnityEngine;

public class Ataque : MonoBehaviour
{
    public Inimigo inimigo;
    private int ataque;
    

    public int AtaqueDoInimigo()
    {
        ataque = inimigo.DanoDoInimigo();
        return ataque;
    }
}