using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void TransformScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.name == "Player_Animated")
        {
            Debug.Log("Collision");
            TransformScene();
        }
    }
}
