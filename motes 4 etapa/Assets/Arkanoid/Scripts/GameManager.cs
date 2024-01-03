using System.Collections;
using System.Collections.Generic;

using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int vidas = 2;
    public int tijolosRestantes;
    
    
    
    public GameObject playerPrefab;
    public GameObject ballPrefab;
    public Transform playerSpawnPoint;
    public Transform ballSpawnPoint;

    public PlayerB playerAtual;
    public BallB ballAtual;

    public TextMeshProUGUI contador;
    public TextMeshProUGUI msgFinal;

    public bool segurando;
    private Vector3 offset;
     private void Awake()
     {
         throw new NotImplementedException();
     }
// Start is called before the first frame update
    void Start()
    {
        
    }

    
    {
    }

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
