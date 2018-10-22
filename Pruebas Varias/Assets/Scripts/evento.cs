using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class evento : MonoBehaviour
{
    public string Evento = "";

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnMouseUp);
    }

    void OnMouseUp()
    {
        SceneManager.LoadScene(Evento, LoadSceneMode.Single);
    }
}