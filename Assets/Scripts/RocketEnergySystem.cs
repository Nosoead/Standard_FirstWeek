using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketEnergySystem : MonoBehaviour
{
    [SerializeField] private Image fuelGauge;
    private Rocket rocket;
    private void Awake()
    {
        rocket = GetComponent<Rocket>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Currentfillamount();
    }

    private void Currentfillamount()
    {
        float fuelAmountNum = rocket.fuel / 100.1f;
        fuelGauge.fillAmount = fuelAmountNum;
    }

}
