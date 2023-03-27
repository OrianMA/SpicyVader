using BaseTemplate.Behaviours;


public class GameManager : MonoSingleton<GameManager>
{
    private void Awake()
    {
        PlayerManager.Instance.Init();
    }
}
