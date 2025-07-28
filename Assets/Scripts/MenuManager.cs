using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public string input;

    public int highScore;
    public Text highScoreText;

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

        //string bestPlayerName = PlayerPrefs.GetString("HighScoreName", "");
        //highScoreText.text = "Best Score : " + bestPlayerName + " : " + MenuManager.Instance.highScore;
    }

    public void UpdateHighScoreText()
    {
        // Always get the latest reference in case the scene changed
        highScoreText = GameObject.Find("HighScoreText")?.GetComponent<Text>();

        // Always fetch the latest values from PlayerPrefs
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        string bestPlayerName = PlayerPrefs.GetString("HighScoreName", "");

        if (highScoreText != null)
        {
            highScoreText.text = "Best Score : " + bestPlayerName + " : " + highScore;
        }
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
