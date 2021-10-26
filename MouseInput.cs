bool isButtonDown;
isButtonDown = Input.GetMouseButtonDown(0); //left mouse button
isButtonDown = Input.GetMouseButtonDown(1); //right mouse button
isButtonDown = Input.GetMouseButtonDown(3); //center mouse button

float value;
value = Input.GetAxis("Mouse X"); //x axis movement
value = Input.GetAxis("Mouse Y"); //y axis movement

/* 
Unlike button presses, the mouse movement is measured by the amount the mouse has moved since the
last frame only. Basically, holding a key will cause a value to increase until it maxes out at –1 or 1
(depending on whether is it positive or negative). The mouse movement, however, will generally
have smaller numbers because it is measured and reset every frame.

*/

