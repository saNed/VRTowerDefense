using UnityEngine;
using System.Collections;

public class NodeManager : MonoBehaviour {

	public GameObject node;
	public GameObject nodeRenderer;
	public GameObject playerBase;

	// Use this for initialization
	void Start () {
		for (int i = -9; i <= 9; i++) {
			for (int j = -9; j <= 9; j++) {
				GameObject n = (GameObject) Instantiate(node, new Vector3 (i, 0, j), Quaternion.identity, this.transform);
				n.name = i + " x " + j;

				GameObject nr = (GameObject) Instantiate (nodeRenderer, new Vector3 (i, nodeRenderer.transform.position.y, j), Quaternion.identity, n.transform);
				if ((i == 7 || i == -7) && (j == 7 || j == -7)) {
					Instantiate(playerBase, n.transform.position, n.transform.rotation, n.transform);
				}
			}
		}
	}
}
