using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMoveController : MonoBehaviour {

	// PUBLIC
	public SimpleTouchController leftController;
	public SimpleTouchController rightController;
	public Transform headTrans;
	public float speedMovements = 5f;
	public float speedContinuousLook = 100f;
	public float speedProgressiveLook = 3000f;
    public float angle = 0;
    public Quaternion initial;
    private GameObject heroi;
    // PRIVATE
    private Rigidbody _rigidbody;
	[SerializeField] bool continuousRightController = true;

	void Start()
	{
        leftController = GameObject.FindGameObjectWithTag("Esquerda").GetComponent<SimpleTouchController>();
        rightController = GameObject.FindGameObjectWithTag("Direita").GetComponent<SimpleTouchController>();
        heroi = GameObject.FindGameObjectWithTag("Heroi");
        _rigidbody = GetComponent<Rigidbody>();
        initial = _rigidbody.rotation;
        rightController.TouchEvent += RightController_TouchEvent;

     


    }

	public bool ContinuousRightController
	{
		set{continuousRightController = value;}
	}

	void RightController_TouchEvent (Vector2 value)
	{
		if(!continuousRightController)
		{
			UpdateAim(value);
		}
	}

	void Update()
	{
        // move
        Vector3 aux = _rigidbody.position;
        _rigidbody.MovePosition(transform.position + (transform.forward * leftController.GetTouchPosition.y * Time.deltaTime * speedMovements) +
			(transform.right * leftController.GetTouchPosition.x * Time.deltaTime * speedMovements) );
        
        if (heroi.transform.rotation.eulerAngles.x>60 && heroi.transform.rotation.eulerAngles.x < 70)
        {
          heroi.transform.rotation = Quaternion.Euler(59, heroi.transform.rotation.eulerAngles.y, heroi.transform.rotation.eulerAngles.z);

        }else if (heroi.transform.rotation.eulerAngles.x >320 && heroi.transform.rotation.eulerAngles.x <330)
        {
            heroi.transform.rotation = Quaternion.Euler(340, heroi.transform.rotation.eulerAngles.y, heroi.transform.rotation.eulerAngles.z);

        }
       // print(heroi.transform.rotation.eulerAngles);
         
        if (continuousRightController)
		{
			UpdateAim(rightController.GetTouchPosition);
		}
	}

	void UpdateAim(Vector2 value)
	{
        switch (PlayerPrefs.GetInt("Joystick"))
        {
            case 0:
                speedProgressiveLook = 250f;
                break;
            case 1:
               speedProgressiveLook = 100f;
                break;
            case 2:
                speedProgressiveLook = 50f;
                break;
        }

        if (headTrans != null)
		{
            
			Quaternion rot = Quaternion.Euler(0f,
				transform.localEulerAngles.y - value.x * Time.deltaTime * -speedProgressiveLook,
				0f);

			_rigidbody.MoveRotation(rot);

			rot = Quaternion.Euler(headTrans.localEulerAngles.x - value.y * Time.deltaTime * speedProgressiveLook,
				0f,
				0f);
			headTrans.localRotation = rot;

		}
		else
		{

			Quaternion rot = Quaternion.Euler(transform.localEulerAngles.x - value.y * Time.deltaTime * speedProgressiveLook,
				transform.localEulerAngles.y + value.x * Time.deltaTime * speedProgressiveLook,
				0f);

			_rigidbody.MoveRotation(rot);
		}
	}

	void OnDestroy()
	{
		rightController.TouchEvent -= RightController_TouchEvent;
	}

}
