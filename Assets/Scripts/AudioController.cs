using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static bool audioJaTocado = false; // Variável estática para controlar se o áudio já foi tocado
    public AudioSource audioSource; // Referência para o AudioSource

    void Start()
    {
        if (!audioJaTocado)
        {
            audioSource.Play(); // Toca o áudio apenas se não foi tocado antes
            audioJaTocado = true; // Marca que o áudio já foi tocado
        }
    }
}