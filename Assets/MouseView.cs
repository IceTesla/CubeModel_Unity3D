using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MouseView : MonoBehaviour {
//	public float roate_Speed=10.0f;
//	public Transform tag;
//	public Text textdlg;
//	private string smx;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
/*		Transform target = tag;
		if(Input.GetKey(KeyCode.A)){
			target.transform.Rotate(new Vector3(0,1,0),1);*/
			//Transform target_transform = tag;//不用绑定对象，下面代码动态获取对象  
	//		if (Input.GetMouseButton(0))  
	//		{  
				
				//在屏幕上转换坐标：将鼠标点转换成射线  
				/*Ray rayObj = Camera.main.ScreenPointToRay(Input.mousePosition);  
				RaycastHit hitObj;  
				if (Physics.Raycast(rayObj, out hitObj))  
				{  
					//Debug.Log("射线得到的对象名称：" + hitObj.collider.name);  
					target_transform = hitObj.transform;  
				}  
				*/
				
	//			if (target_transform != null)  
		//		{  
					//Debug.Log("射线取得对象");  

		//		    float mousX = Input.GetAxis("Mouse X") * roate_Speed;//得到鼠标移动距离  
		//		    smx=Input.GetAxis("Mouse X").ToString();
		//		    float mousY = Input.GetAxis("Mouse Y") * roate_Speed;//得到鼠标移动距离  

		//				Debug.Log(smx);
		//

				    //float mousZ = Input.GetAxis("Mouse Z") * roate_Speed;//得到鼠标移动距离 
			//		target_transform.transform.Rotate(new Vector3(0, -mousX, 0));  
			//		target_transform.transform.Rotate(new Vector3(-mousY, 0, 0));  
					//target_transform.transform.Rotate(new Vector3(0, 0, -mousZ));  
		//		}  
		//		else  
		//		{  
		//			Debug.Log("未取得对象");  
		//		}  
		//	}  

		}
}
