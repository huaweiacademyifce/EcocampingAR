using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [Tooltip("Nome da cena que voc� quer carregar.")]
    public string sceneName;

    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("O nome da cena est� vazio. Verifique o campo 'sceneName' no inspetor.");
        }
    }
}