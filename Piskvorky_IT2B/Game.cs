﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskvorky_IT2B
{
  public class Game
  {
    public List<GameObject> GameObjects { get; } = new List<GameObject>();
    public int Top
    {
      get
      {
        if (GameObjects.Count == 0)
        {
          return 0;
        }
        else if (GameObjects.Count == 1)
        {
          return 5;
        }
        else
        {
          int top = 0;
          foreach (GameObject obj in GameObjects)
          {
            if (obj.Y > top)
            {
              top = obj.Y;
            }
          }
          return top + 5;
        }
      }
    }
    public int Bottom
    {
      get
      {
        if (GameObjects.Count == 0)
        {
          return 0;
        }
        else if (GameObjects.Count == 1)
        {
          return 5;
        }
        else
        {
          int bottom = 0;
          foreach (GameObject obj in GameObjects)
          {
            if (obj.Y < bottom)
            {
              bottom = obj.Y;
            }
          }
          return Math.Abs(bottom) + 5;
        }
      }
    }
    public int Left
    {
      get
      {
        if (GameObjects.Count == 0)
        {
          return 0;
        }
        else if (GameObjects.Count == 1)
        {
          return 5;
        }
        else
        {
          int left = 0;
          foreach (GameObject obj in GameObjects)
          {
            if (obj.X < left)
            {
              left = obj.X;
            }
          }
          return Math.Abs(left) + 5;
        }
      }
    }
    public int Right
    {
      get
      {
        if (GameObjects.Count == 0)
        {
          return 0;
        }
        else if (GameObjects.Count == 1)
        {
          return 5;
        }
        else
        {
          int right = 0;
          foreach (GameObject obj in GameObjects)
          {
            if (obj.X > right)
            {
              right = obj.X;
            }
          }
          return Math.Abs(right) + 5;
        }
      }
    }
  }
}
