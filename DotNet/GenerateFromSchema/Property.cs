﻿using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace GenerateFromSchema
{
    public class Property
    {
        public string Name { get; set; }

        public string Description
        {
            get => m_description ?? ValueTypeDescription ?? Name;
            set => m_description = value;
        }

        private string ValueTypeDescription => ValueType?.Description;

        public Schema ValueType { get; set; }

        public JToken Default { get; set; }

        public List<string> Examples { get; set; }

        public bool IsValue { get; set; }
        public bool IsRequired { get; set; }

        public string NameWithPascalCase
        {
            get
            {
                if (Name.Length == 0)
                    return Name;

                string name = string.IsNullOrEmpty(ValueType.ExtensionPrefix) ? Name : Name.Substring(ValueType.ExtensionPrefix.Length + 1);
                return name.CapitalizeFirstLetter();
            }
        }

        public bool IsInterpolatable => ValueType.IsInterpolatable;

        private string m_description;
    }
}