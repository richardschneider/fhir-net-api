﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011-2013, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Thu, Apr 24, 2014 12:29+0200 for FHIR v0.80
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A measured or measurable amount
    /// </summary>
    [FhirType("Quantity")]
    [DataContract]
    public partial class Quantity : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// How the Quantity should be understood and represented
        /// </summary>
        [FhirEnumeration("QuantityCompararator")]
        public enum QuantityCompararator
        {
            /// <summary>
            /// The actual value is less than the given value.
            /// </summary>
            [EnumLiteral("<")]
            LessThan,
            /// <summary>
            /// The actual value is less than or equal to the given value.
            /// </summary>
            [EnumLiteral("<=")]
            LessOrEqual,
            /// <summary>
            /// The actual value is greater than or equal to the given value.
            /// </summary>
            [EnumLiteral(">=")]
            GreaterOrEqual,
            /// <summary>
            /// The actual value is greater than the given value.
            /// </summary>
            [EnumLiteral(">")]
            GreaterThan,
        }
        
        /// <summary>
        /// Numerical value (with implicit precision)
        /// </summary>
        [FhirElement("value", InSummary=true, Order=40)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDecimal ValueElement
        {
            get { return _ValueElement; }
            set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
        }
        private Hl7.Fhir.Model.FhirDecimal _ValueElement;
        
        /// <summary>
        /// Numerical value (with implicit precision)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public decimal? Value
        {
            get { return ValueElement != null ? ValueElement.Value : null; }
            set
            {
                if(value == null)
                  ValueElement = null; 
                else
                  ValueElement = new Hl7.Fhir.Model.FhirDecimal(value);
                OnPropertyChanged("Value");
            }
        }
        
        /// <summary>
        /// &lt; | &lt;= | &gt;= | &gt; - how to understand the value
        /// </summary>
        [FhirElement("comparator", InSummary=true, Order=50)]
        [DataMember]
        public Code<Hl7.Fhir.Model.Quantity.QuantityCompararator> ComparatorElement
        {
            get { return _ComparatorElement; }
            set { _ComparatorElement = value; OnPropertyChanged("ComparatorElement"); }
        }
        private Code<Hl7.Fhir.Model.Quantity.QuantityCompararator> _ComparatorElement;
        
        /// <summary>
        /// &lt; | &lt;= | &gt;= | &gt; - how to understand the value
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.Quantity.QuantityCompararator? Comparator
        {
            get { return ComparatorElement != null ? ComparatorElement.Value : null; }
            set
            {
                if(value == null)
                  ComparatorElement = null; 
                else
                  ComparatorElement = new Code<Hl7.Fhir.Model.Quantity.QuantityCompararator>(value);
                OnPropertyChanged("Comparator");
            }
        }
        
        /// <summary>
        /// Unit representation
        /// </summary>
        [FhirElement("units", InSummary=true, Order=60)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString UnitsElement
        {
            get { return _UnitsElement; }
            set { _UnitsElement = value; OnPropertyChanged("UnitsElement"); }
        }
        private Hl7.Fhir.Model.FhirString _UnitsElement;
        
        /// <summary>
        /// Unit representation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Units
        {
            get { return UnitsElement != null ? UnitsElement.Value : null; }
            set
            {
                if(value == null)
                  UnitsElement = null; 
                else
                  UnitsElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Units");
            }
        }
        
        /// <summary>
        /// System that defines coded unit form
        /// </summary>
        [FhirElement("system", InSummary=true, Order=70)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri SystemElement
        {
            get { return _SystemElement; }
            set { _SystemElement = value; OnPropertyChanged("SystemElement"); }
        }
        private Hl7.Fhir.Model.FhirUri _SystemElement;
        
        /// <summary>
        /// System that defines coded unit form
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public System.Uri System
        {
            get { return SystemElement != null ? SystemElement.Value : null; }
            set
            {
                if(value == null)
                  SystemElement = null; 
                else
                  SystemElement = new Hl7.Fhir.Model.FhirUri(value);
                OnPropertyChanged("System");
            }
        }
        
        /// <summary>
        /// Coded form of the unit
        /// </summary>
        [FhirElement("code", InSummary=true, Order=80)]
        [DataMember]
        public Hl7.Fhir.Model.Code CodeElement
        {
            get { return _CodeElement; }
            set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
        }
        private Hl7.Fhir.Model.Code _CodeElement;
        
        /// <summary>
        /// Coded form of the unit
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Code
        {
            get { return CodeElement != null ? CodeElement.Value : null; }
            set
            {
                if(value == null)
                  CodeElement = null; 
                else
                  CodeElement = new Hl7.Fhir.Model.Code(value);
                OnPropertyChanged("Code");
            }
        }
        
    }
    
}
