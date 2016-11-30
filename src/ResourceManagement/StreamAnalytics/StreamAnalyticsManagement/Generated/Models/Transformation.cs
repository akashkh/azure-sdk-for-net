// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The definition of the transformation.
    /// </summary>
    public partial class Transformation
    {
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the transformation.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private TransformationProperties _properties;
        
        /// <summary>
        /// Optional. Gets or sets the properties of the transformation.
        /// </summary>
        public TransformationProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Transformation class.
        /// </summary>
        public Transformation()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Transformation class with
        /// required arguments.
        /// </summary>
        public Transformation(string name)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name;
        }
    }
}