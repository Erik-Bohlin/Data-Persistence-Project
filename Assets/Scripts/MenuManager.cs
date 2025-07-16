using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public string input;

    public int highScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }
}
