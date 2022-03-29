using UnityEngine.SceneManagement;

public class BossLogic : TDS_Target
{
    void OnDestroy()
    {
        SceneManager.LoadScene("Gameover");
    }
}
