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

        //Load high score and name
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        input = PlayerPrefs.GetString("HighScoreName", "");
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }

    public void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.SetString("HighScoreName", input);
        PlayerPrefs.Save();
    }


}
