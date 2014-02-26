using UnityEngine;
using System.Collections;

public class DicePlusScript : EmptyDicePlusListener, IDicePlusConnectorListener {
	Vector3 currentOrientation;

	// Use this for initialization
	void Start () {
		DicePlusConnector.Instance.registerListener(this);

	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (currentOrientation), Time.deltaTime * 2.5F);
	}

	public override void onRoll(DicePlus dicePlus, long time, int duration, int face, int invalidityFlags, string errorMsg){
		// Accepting only valid rolls.
		if(invalidityFlags == 0) {
//			RollResult.text = face.ToString();
		}
	}

	public override void onOrientationReadout(DicePlus dicePlus, long time, Vector3 v, string errorMsg){
		// X axis goes through 1
		// Y axis goes through 5
		// Z axis goes through 3
//		transform.rotation = Quaternion.Euler(Vector3.zero);
//		transform.Rotate(v);
		currentOrientation = v;
		Debug.DrawRay(Vector3.zero, v, Color.red, 0.05F, false);
		Debug.DrawRay(Vector3.zero, Vector3.forward, Color.green, 0.05F, false);

	}

	public override void onLedState(DicePlus dicePlus, long time, DicePlusConnector.LedFace ledMask, long animationId, int type, string errorMsg){

	}

	public void onNewDie (DicePlus dicePlus)
	{
//		throw new System.NotImplementedException ();
	}

	public void onScanFinished (bool fail)
	{
//		throw new System.NotImplementedException ();
	}

	public void onScanStarted ()
	{
//		throw new System.NotImplementedException ();
	}

	public void onConnectionLost (DicePlus dicePlus)
	{
		dicePlus.unsubscribeOrientationReadouts();
	}

	public void onConnectionEstablished (DicePlus dicePlus)
	{
		dicePlus.registerListener(this);
		dicePlus.subscribeOrientationReadouts(20);
//		dicePlus.subscribeLedState();

	}

	public void onConnectionFailed (DicePlus dicePlus, int errorCode, string excpMsg)
	{
//		throw new System.NotImplementedException ();
	}

	public void onBluetoothStateChanged (DicePlusConnector.BluetoothState state)
	{
//		throw new System.NotImplementedException ();
	}

	void OnGUI(){
		GUI.Label(new Rect(10, 10, 100, 100), currentOrientation.ToString());
	}
}
