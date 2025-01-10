﻿using System;
using System.Security.Cryptography;

namespace RectangleEncapApp.Models
{
     class Rectang
    {
        public int width { get; set; }
	public int height { get; set; }
	public string color { get; set; }

        public int CalculateArea(int w, int h, string c)
        {
		width = w;
		height = h;
		color = c;
            return (height * width * 2);
        }
    }
}
