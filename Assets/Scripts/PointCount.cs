using UnityEngine;
using UnityEngine.UI;
public class PointCount : MonoBehaviour {
    public UnityEngine.UI.Text point;
    int x=0,y;
   public void setPoint()
    {
        int.TryParse(point.text, out x);
        y = x+10;
        point.text = y.ToString();
    }
}
