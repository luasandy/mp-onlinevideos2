﻿namespace ZDFMediathek2009.Code.DTO
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    [Serializable, GeneratedCode("xsd", "2.0.50727.3038"), DesignerCategory("code"), XmlType(AnonymousType=true), XmlRoot(Namespace="", IsNullable=false), DebuggerStepThrough]
    public class ivwUrls
    {
        private ZDFMediathek2009.Code.DTO.value[] valueField;

        [XmlElement("value")]
        public ZDFMediathek2009.Code.DTO.value[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}

