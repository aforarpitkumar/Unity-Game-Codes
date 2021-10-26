//This is here for reference
public class SomeClassScript : MonoBehaviour {
  //This is the game object you want to access
  public GameObject target;
  //This is here for reference
  void Start() {
    target = GameObject.Find("Cube");
  }
}
