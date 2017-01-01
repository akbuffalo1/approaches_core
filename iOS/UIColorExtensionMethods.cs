﻿#if __IOS__
namespace AD.iOS
{
	using System;
	using UIKit;
	
	public static class UIColorExtensions
    {
        public static UIColor FromHex(this UIColor color, int hexValue, float alpha = 1F)
        {
            return UIColor.FromRGBA(
                (((float)((hexValue & 0xFF0000) >> 16))/255.0f),
                (((float)((hexValue & 0xFF00) >> 8))/255.0f),
                (((float)(hexValue & 0xFF))/255.0f),
				alpha
            );
        }
    }
}
#endif