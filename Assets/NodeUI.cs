using UnityEngine;
using System.Collections;

public class NodeUI : MonoBehaviour {

    private Node target;
    public GameObject ui;
    public int upgradeCost;
    public int sellAmount;


    //public void setTarget (Node _target)
    //{
    //    target = _target;
    //    transform.position = target.getPosition();
    //}

    //public void hide()
    //{
    //    ui.setactive(false);
    //}

    //public void Upgrade()
    //{
    //    target.UpgradeTurret();
    //    BuildManager.instance.DeselectNode();
    //}

    //public void Sell()
    //{
    //    target.SellTurret();
    //    BuildManager.instance.DeselectNode();
    //}

}
