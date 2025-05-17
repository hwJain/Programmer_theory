using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vehicles[] vehicles;
    private Vehicles currentVehicle; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out RaycastHit hit))
            {
                Vehicles clickedVehicle= hit.collider.GetComponent<Vehicles>();
                if (clickedVehicle != null)
                {
                    SetActiveVehicle(clickedVehicle);
                }
            }
        }
        if (currentVehicle != null)
        {
            currentVehicle.Drive();
        }


    }
    void SetActiveVehicle (Vehicles selectedvehicle)
    {
        foreach (var v in vehicles)
        {
            v.isPlayerControlled= (v == selectedvehicle);
        }
        currentVehicle= selectedvehicle;
        Debug.Log("Selected Vehicle: " + selectedvehicle.name);
    } 
}
