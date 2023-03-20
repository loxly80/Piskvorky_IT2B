using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskvorky_IT2B
{
  public class GameObject
  {
    public int X { get; }
    public int Y { get; }
    public ValueType Value { get; }

    public GameObject(int x, int y, ValueType value)
    {
      X = x;
      Y = y;
      Value = value;
    }

    public enum ValueType
    {
      Circle,
      Cross
    }
  }
}
