﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace TerritoryMgr.Infrastructure
{
    public static class Extensions
    {
        // TODO: Document these extensions with /// comments
        public static string SplitCamelCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";

            return Regex.Replace(
                Regex.Replace(
                    str,
                    @"(\P{Ll})(\P{Ll}\p{Ll})",
                    "$1 $2"
                ),
                @"(\p{Ll})(\P{Ll})",
                "$1 $2"
            );
        }

        public static string ToHtml(this string str)
        {
            str = str?.Replace("\n", "<br />");
            return str;
        }

        public static string EnumDisplayName(this Enum item)
        {
            var type = item.GetType();
            var member = type.GetMember(item.ToString());
            var displayname = (DisplayAttribute)member[0].GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault();

            return displayname != null ? displayname.Name : item.ToString();
        }

        public static string EnumDescription(this Enum item)
        {
            FieldInfo fieldInfo = item.GetType().GetField(item.ToString());
            if (fieldInfo == null) return null;
            var attribute = (DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute));
            return attribute.Description;
        }

        public static string Icon(this bool value)
        {
            return value ? "check" : "close";
        }

        public static string Icon(this string str)
        {
            // Check/X icon for strings that start with "Not..."
            return str.ToUpper().StartsWith("NOT") ? "close" : "check";
        }

        public static string Not(this bool value)
        {
            return value ? "" : "not ";
        }

        public static string Has(this bool value)
        {
            return value ? "has " : "does not have ";
        }

        public static string LookupValue(this SelectList list, int value)
        {
            if (list == null || !list.Any())
            {
                return "";
            }
            else
            {
                return list.Where(i => i.Value == value.ToString()).Select(i => i.Text).FirstOrDefault();
            }
        }

        public static string LookupValue(this SelectList list, string value)
        {
            if (list == null || !list.Any())
            {
                return "";
            }
            else
            {
                return list.Where(i => i.Value == value).Select(i => i.Text).FirstOrDefault();
            }
        }

    }
}