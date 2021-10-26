//Moves the object along the positive x axis.
//The '0f' means 0 as a float. It is the way Unity reads floats
transform.Translate(.05f, 0f, 0f);
//Rotates the object along the z axis
transform.Rotate(0f, 0f, 1f);
//Scales the object to double its size in all directions
transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
