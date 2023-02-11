using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance { get; private set; }    // ENCAPSULATION
    public int VehicleType { get; private set; }    // ENCAPSULATION
    private bool isVehicleSelected = false;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            Destroy(Instance);
            //return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void StartGame()
    {
        if (isVehicleSelected)
            SceneManager.LoadScene(1);
        else
            Debug.Log("Select a vehicle type first!");
    }
    public void Car()
    {
        isVehicleSelected = true;
        VehicleType = 0;
    }
    public void Van()
    {
        isVehicleSelected = true;
        VehicleType = 1;
    }
    public void Jet()
    {
        isVehicleSelected = true;
        VehicleType = 2;
    }
}
