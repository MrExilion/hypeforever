using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MapScript : MonoBehaviour {

    [SerializeField]
    private Canvas m_Map;
    [SerializeField]
    private Image m_HypePosition;
    [SerializeField]
    private Image m_2DOrigo;
    private Vector3 m_FPSController;
    private Vector3 m_FPSControllerUpdate;
    private Vector3 m_FPSControllerDifference;
    private Vector3 m_HypePosition2;
    private Vector3 m_HypePosition3;
    private float m_FPSControllerDifferenceX;
    private float m_FPSControllerDifferenceZ;
    private Vector3 m_FPSControllerConverted;
    private Vector3 m_Origo;
    private Vector3 m_2DOrigoVec;
    private float m_xdif;
    private float m_ydif;
    private float m_zdif;
    private float m_zydif;
    private float m_xxdif;
    private float m_xdif2;
    private SceneController m_SceneController;

    void Awake()
    {
        m_FPSController = GameObject.Find("FPSController").GetComponent<Transform>().position;
        m_SceneController = GameObject.Find("SceneControllerObject").GetComponent<SceneController>();

       /* m_Origo = GameObject.Find("Origo").GetComponent<Transform>().position;

        m_2DOrigoVec = m_2DOrigo.rectTransform.position;

        m_xdif = m_FPSController.x*10 - m_Origo.x*10;
        m_zdif = m_FPSController.z*10 - m_Origo.z*10;
        Debug.Log(" " + m_xdif + " " + m_zdif);

        m_xdif2 = m_2DOrigoVec.x*10 - m_Origo.x*10;
        m_ydif = m_2DOrigoVec.y*10 - m_Origo.y*10;
        Debug.Log(" " + m_xdif2 + " " + m_ydif);

        m_zydif = m_ydif - m_zdif*100;
        m_xxdif = m_xdif2 - m_xdif;
        Debug.Log(" " + m_zydif + " " + m_xxdif);


        
        m_HypePosition.transform.position.Set(m_xxdif, m_zydif, 0.0f);
        m_HypePosition2 = m_HypePosition.transform.position;
        Debug.Log(m_HypePosition2);*/

    }

	// Use this for initialization
	void Start () {
        // m_FPSController = GameObject.Find("FPSController").GetComponent<Transform>().position;

        m_HypePosition.transform.position.Set(m_xxdif, m_zydif, 0.0f);
        m_HypePosition2 = m_HypePosition.transform.position;
        Debug.Log(m_HypePosition2);
        m_HypePosition3 = m_HypePosition2;
        Debug.Log(m_HypePosition2);

    }
	
	// Update is called once per frame
	void Update () {
        m_FPSControllerUpdate = GameObject.Find("FPSController").GetComponent<Transform>().position;
        m_FPSControllerDifference = m_FPSControllerUpdate - m_FPSController;

        m_FPSControllerDifferenceX = m_FPSControllerDifference.x * 2;
        m_FPSControllerDifferenceZ = m_FPSControllerDifference.z *2;
        m_FPSControllerConverted.Set(m_FPSControllerDifferenceX, m_FPSControllerDifferenceZ, 0.0f);



        m_HypePosition.rectTransform.position = m_HypePosition3 + m_FPSControllerConverted * 2;




        if (Input.GetButtonDown("Map")) {


            
            m_SceneController.canvasSwapper(4);
            

        }





    }
}
