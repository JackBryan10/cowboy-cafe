/* Author: Jack Walter
 * Class Name: ExtensionMethods.cs
 * Purpose: A static class containing the Order Control for Cowboy Cafe Point of Sale
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    /// <summary>
    /// 
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Recursively finds the ancestor window element of the current window. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <returns>Type T</returns>
        public static T FindAncestor<T>(this DependencyObject element) where T: DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if (parent == null) { return null; }

            if (parent is T) return parent as T;

            return parent.FindAncestor<T>();
        }
    }
}
