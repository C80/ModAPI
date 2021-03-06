﻿/*  
 *  ModAPI
 *  Copyright (C) 2015 FluffyFish / Philipp Mohrenstecher
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *  
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *  
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *  
 *  To contact me you can e-mail me at info@fluffyfish.de
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ModAPI.Utils
{
    public static class XMLHelper
    {

        public static bool GetXMLAttributeAsBoolean(XElement element, string attributeName, bool standardValue = false)
        {
            XAttribute attribute = element.Attribute(attributeName);
            if (attribute != null)
            {
                try
                {
                    return Convert.ToBoolean(attribute.Value);
                }
                catch (Exception e) { }
            }
            return standardValue;
        }

        public static double GetXMLAttributeAsDouble(XElement element, string attributeName, double standardValue = 0.0)
        {
            XAttribute attribute = element.Attribute(attributeName);
            if (attribute != null)
            {
                try
                {
                    return Convert.ToDouble(attribute.Value);
                }
                catch (Exception e) { }
            }
            return standardValue;
        }

        public static float GetXMLAttributeAsFloat(XElement element, string attributeName, float standardValue = 0.0f)
        {
            XAttribute attribute = element.Attribute(attributeName);
            if (attribute != null)
            {
                try
                {
                    return float.Parse(attribute.Value.Replace(".",","));
                }
                catch (Exception e) { }
            }
            return standardValue;
        }

        public static int GetXMLAttributeAsInt(XElement element, string attributeName, int standardValue = 0)
        {
            XAttribute attribute = element.Attribute(attributeName);
            if (attribute != null)
            {
                try
                {
                    return Convert.ToInt32(attribute.Value);
                }
                catch (Exception e) { }
            }
            return standardValue;
        }

        public static string GetXMLAttributeAsString(XElement element, string attributeName, string standardValue = "")
        {
            XAttribute attribute = element.Attribute(attributeName);
            if (attribute != null)
            {
                try
                {
                    return Convert.ToString(attribute.Value);
                }
                catch (Exception e) { }
            }
            return standardValue;
        }

        public static string GetXMLElementAsString(XElement element, string elementName, string standardValue = "")
        {
            XElement subElement = element.Element(elementName);
            if (subElement != null)
            {
                try
                {
                    return Convert.ToString(subElement.Value);
                }
                catch (Exception e) { }
            }
            return standardValue;
        }

        public static double GetXMLElementAsDouble(XElement element, string elementName, double standardValue = 0.0)
        {
            XElement subElement = element.Element(elementName);
            if (subElement != null)
            {
                try
                {
                    return Convert.ToDouble(subElement.Value);
                }
                catch (Exception e) { }
            }
            return standardValue;
        }

        public static float GetXMLElementAsFloat(XElement element, string elementName, float standardValue = 0f)
        {
            XElement subElement = element.Element(elementName);
            if (subElement != null)
            {
                try
                {
                    return float.Parse(subElement.Value.Replace(".",","));
                }
                catch (Exception e) { }
            }
            return standardValue;
        }

        public static bool GetXMLElementAsBoolean(XElement element, string elementName, bool standardValue = false)
        {
            XElement subElement = element.Element(elementName);
            if (subElement != null)
            {
                try
                {
                    return Convert.ToBoolean(subElement.Value);
                }
                catch (Exception e) { }
            }
            return standardValue;
        }
        public static int GetXMLElementAsInt(XElement element, string elementName, int standardValue = 0)
        {
            XElement subElement = element.Element(elementName);
            if (subElement != null)
            {
                try
                {
                    return Convert.ToInt32(subElement.Value);
                }
                catch (Exception e) { }
            }
            return standardValue;
        }
    }
}
