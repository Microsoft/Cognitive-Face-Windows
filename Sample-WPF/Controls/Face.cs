﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.
//
// Microsoft Cognitive Services (formerly Project Oxford): https://www.microsoft.com/cognitive-services
//
// Microsoft Cognitive Services (formerly Project Oxford) GitHub:
// https://github.com/Microsoft/Cognitive-Face-Windows
//
// Copyright (c) Microsoft Corporation
// All rights reserved.
//
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace Microsoft.CognitiveServices.Face.Controls
{
    /// <summary>
    /// Face view model
    /// </summary>
    public class Face : INotifyPropertyChanged
    {
        #region Fields

        /// <summary>
        /// Face gender text string
        /// </summary>
        private string _gender;

        /// <summary>
        /// Face age text string
        /// </summary>
        private string _age;

        /// <summary>
        /// confidence value of this face to a target face
        /// </summary>
        private double _confidence;

        /// <summary>
        /// Person name
        /// </summary>
        private string _personName;

        /// <summary>
        /// Face height in pixel
        /// </summary>
        private int _height;

        /// <summary>
        /// Face position X relative to image left-top in pixel
        /// </summary>
        private int _left;

        /// <summary>
        /// Face position Y relative to image left-top in pixel
        /// </summary>
        private int _top;

        /// <summary>
        /// Face width in pixel
        /// </summary>
        private int _width;

        /// <summary>
        /// Facial hair display string
        /// </summary>
        private string _facialHair;

        /// <summary>
        /// Indicates the glasses type
        /// </summary>
        private string _glasses;

        /// <summary>
        /// Indicates the headPose
        /// </summary>
        private string _headPose;

        /// <summary>
        /// Indicates the emotion
        /// </summary>
        private string _emotion;

        /// <summary>
        /// Indicates the blur
        /// </summary>
        private string _blur;

        /// <summary>
        /// Indicates the exposure
        /// </summary>
        private string _exposure;

        /// <summary>
        /// Indicates the noise
        /// </summary>
        private string _noise;

        /// <summary>
        /// Indicates the makeup
        /// </summary>
        private string _makeup;

        /// <summary>
        /// Indicates the accessories
        /// </summary>
        private string _accessories;

        /// <summary>
        /// Indicates the occlusion
        /// </summary>
        private string _occlusion;

        /// <summary>
        /// Indicates the hair
        /// </summary>
        private string _hair;

        #endregion Fields

        #region Events

        /// <summary>
        /// Implement INotifyPropertyChanged interface
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        /// <summary>
        /// Gets or sets gender text string 
        /// </summary>
        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
                OnPropertyChanged<string>();
            }
        }

        /// <summary>
        /// Gets or sets age text string
        /// </summary>
        public string Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
                OnPropertyChanged<string>();
            }
        }

        /// <summary>
        /// Gets or sets confidence value
        /// </summary>
        public double Confidence
        {
            get
            {
                return _confidence;
            }

            set
            {
                _confidence = value;
                OnPropertyChanged<double>();
            }
        }

        /// <summary>
        /// Gets face rectangle on image
        /// </summary>
        public System.Windows.Int32Rect UIRect
        {
            get
            {
                return new System.Windows.Int32Rect(Left, Top, Width, Height);
            }
        }

        /// <summary>
        /// Gets or sets image path
        /// </summary>
        public ImageSource ImageFile
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets face id
        /// </summary>
        public string FaceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets person's name
        /// </summary>
        public string PersonName
        {
            get
            {
                return _personName;
            }

            set
            {
                _personName = value;
                OnPropertyChanged<string>();
            }
        }

        /// <summary>
        /// Gets or sets face height
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
                OnPropertyChanged<int>();
            }
        }

        /// <summary>
        /// Gets or sets face position X
        /// </summary>
        public int Left
        {
            get
            {
                return _left;
            }

            set
            {
                _left = value;
                OnPropertyChanged<int>();
            }
        }

        /// <summary>
        /// Gets or sets face position Y
        /// </summary>
        public int Top
        {
            get
            {
                return _top;
            }

            set
            {
                _top = value;
                OnPropertyChanged<int>();
            }
        }

        /// <summary>
        /// Gets or sets face width
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
                OnPropertyChanged<int>();
            }
        }

        /// <summary>
        /// Gets or sets facial hair display string
        /// </summary>
        public string FacialHair
        {
            get
            {
                return _facialHair;
            }

            set
            {
                _facialHair = value;
                OnPropertyChanged<string>();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating the glasses type 
        /// </summary>
        public string Glasses
        {
            get
            {
                return _glasses;
            }

            set
            {
                _glasses = value;
                OnPropertyChanged<string>();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating the head pose value.
        /// </summary>
        public string HeadPose
        {
            get { return _headPose; }
            set
            {
                _headPose = value;
                OnPropertyChanged<string>();
            }
        }

        public string Emotion
        {
            get { return _emotion; }
            set
            {
                _emotion = value;
                OnPropertyChanged<string>();
            }
        }

        public string Blur
        {
            get { return _blur; }
            set
            {
                _blur = value;
                OnPropertyChanged<string>();
            }
        }

        public string Exposure
        {
            get { return _exposure; }
            set
            {
                _exposure = value;
                OnPropertyChanged<string>();
            }
        }

        public string Noise
        {
            get { return _noise; }
            set
            {
                _noise = value;
                OnPropertyChanged<string>();
            }
        }

        public string Makeup
        {
            get { return _makeup; }
            set
            {
                _makeup = value;
                OnPropertyChanged<string>();
            }
        }

        public string Accessories
        {
            get { return _accessories; }
            set
            {
                _accessories = value;
                OnPropertyChanged<string>();
            }
        }

        public string Occlusion
        {
            get { return _occlusion; }
            set
            {
                _occlusion = value;
                OnPropertyChanged<string>();
            }
        }

        public string Hair
        {
            get { return _hair; }
            set
            {
                _hair = value;
                OnPropertyChanged<string>();
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// NotifyProperty Helper functions
        /// </summary>
        /// <typeparam name="T">property type</typeparam>
        /// <param name="caller">property change caller</param>
        private void OnPropertyChanged<T>([CallerMemberName]string caller = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }

        #endregion Methods
    }
}