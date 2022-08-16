using UnityEngine;
public class PlayerStaminaController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    private float time = 1;
    private float currentTime;
    public float currentStamina;
    public bool staminaIsFinish;
    public Material material;



    private void Start()
    {
        SetCurrentStamina();
    }



    public void SetCurrentStamina()
    {
        currentStamina = playerDataTransmitter.GetStaminaValue();
    }



    void Update()
    {
        SetPlayerStamina();
        SetPlayerMaterial();
    }



    private void SetPlayerStamina()
    {
        if (currentTime <= 0)
        {
            currentTime = time;
            if (playerDataTransmitter.GetIsTouch())
            {
                currentStamina--;
                Debug.Log(currentStamina);
            }
        }

        else
        {
            currentTime -= Time.deltaTime;
        }

    }



    private void SetPlayerMaterial()
    {
        if (currentStamina <= 5)
        {
            material.mainTextureOffset = new Vector2(0, -0.75f);
        }
        if (currentStamina <= 0)
        {
            staminaIsFinish = true;
        }
    }



    private void OnDestroy()
    {
        material.mainTextureScale = new Vector2(0, 5);
        material.mainTextureOffset = new Vector2(0, 2.5f);
    }
}
