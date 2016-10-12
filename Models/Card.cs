﻿using System;
using System.Drawing;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Pędzące_Żółwie.Models
{
    public class Card
    {
        public Card(Bitmap bitmap, Turtle color, string sign, int value)
        {
            CardImage = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            Color = color;
            Sign = sign;
            Value = value;
        }

        public BitmapSource CardImage { get; }

        public Turtle Color { get; }

        public string Sign { get; }

        public int Value { get; }
    }
}