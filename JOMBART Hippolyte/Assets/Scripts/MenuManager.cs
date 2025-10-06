using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    [SerializeField] private GameObject menu;
    [SerializeField] private KeyCode menuKey = KeyCode.Escape;
    
    private void Start()
    {
        menu.SetActive(false);
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(menuKey))
        {
            OpenCloseMenu();
        }
    }
    
    public void OpenCloseMenu()
    {
        menu.SetActive(!menu.activeSelf);
        if(menu.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}