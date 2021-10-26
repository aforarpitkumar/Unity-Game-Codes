//This is here for reference
public class SomeClassScript : MonoBehaviour {
  //This is the game object you want to access
  public GameObject target;
  //This is here for reference
  void Start() {
    target = GameObject.Find("Cube");
  }
}

// The shortcoming of this method is that it just returns the first item it finds with the given name. 
// If you have multiple Cube objects, you won’t know which one you are getting.
