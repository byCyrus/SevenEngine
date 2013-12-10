﻿// SEVENENGINE LISCENSE:
// You are free to use, modify, and distribute any or all code segments/files for any purpose
// including commercial use under the following condition: any code using or originally taken 
// from the SevenEngine project must include citation to its original author(s) located at the
// top of each source code file, or you may include a reference to the SevenEngine project as
// a whole but you must include the current SevenEngine official website URL and logo.
// - Thanks.  :)  (support: seven@sevenengine.com)

// Author(s):
// - Zachary Aaron Patten (aka Seven) seven@sevenengine.com
// Last Edited: 11-16-13

using SevenEngine.Mathematics;

namespace SevenEngine.Physics.Primitives
{
  public class Sphere
  {
    Vector _position;
    float _radius;
    Quaternion _orientation;

    public Vector Position { get { return _position; } set { _position = value; } }
    public float Radius { get { return _radius; } set { _radius = value; } }
    public Quaternion Orientation { get { return _orientation; } set { _orientation = value; } }

    public Sphere(Vector position, float radius, Quaternion orientation)
    {
      _position = position;
      _radius = radius;
      _orientation = orientation;
    }

  }
}