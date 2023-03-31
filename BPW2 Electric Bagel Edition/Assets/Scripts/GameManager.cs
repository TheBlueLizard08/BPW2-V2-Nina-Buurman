using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Monster;
    public void TransformScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.name == "Player_Animated")
        {
            Debug.Log("Collision");
            Monster.SetActive(true);

            Invoke("TransformScene", 2);
        }
    }
}
