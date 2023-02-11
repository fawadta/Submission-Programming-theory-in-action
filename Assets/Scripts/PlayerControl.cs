using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public List<GameObject> Vehicles;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Vehicles[MenuManager.Instance.VehicleType]);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
