//   Copyright 2017 Esri
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at

//       http://www.apache.org/licenses/LICENSE-2.0

//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Controls;
using System.Xml.Linq;

namespace MapToolWithOverlayControl
{
    /// <summary>
    /// ViewModel for the embeddable control.
    /// </summary>
    internal class EmbeddedControlViewModel : EmbeddableControl
    {
        public EmbeddedControlViewModel(XElement options, bool canChangeOption) : base(options, canChangeOption)
        {
        }

        /// <summary>
        /// Text shown in the control.
        /// </summary>
        private string _text = "Click in view to show coordinates";
        public string Text
        {
            get { return _text; }
            set
            {
                SetProperty(ref _text, value, () => Text);
            }
        }
    }
}
