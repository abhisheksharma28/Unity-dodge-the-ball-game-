using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanage : MonoBehaviour {

    bool gamehasended = false;
    public float restartdelay = 1f;

	public void EndGame()
    {
        if(gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("game over");
            //restart game
            Invoke("restart", restartdelay);
        }
    }
    void restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
