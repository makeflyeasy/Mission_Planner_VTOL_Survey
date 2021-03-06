
#region BSD License
/*
    Copyright (c) 2010 Miguel Angel Guirado López

    This file is part of CsAssortedWidgets.

    All rights reserved.
 
    This file is a C# port of AssortedWidgets project. Original authors see readme.txt file.

    Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

    Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
    Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
    Neither the name of the <ORGANIZATION> nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
    THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#endregion

using System;
using System.Collections.Generic;

using AssortedWidgets.Util;
using AssortedWidgets.Widgets;

namespace AssortedWidgets.Layouts
{
    public abstract class Layout
    {
        public Layout()
        {
            Top = 0;
            Bottom = 0;
            Left = 0;
            Right = 0;
            Spacer = 2;
        }
        public Layout(uint spacer)
        {
            Top = 0;
            Bottom = 0;
            Left = 0;
            Right = 0;
            Spacer = spacer;
        }
        public Layout(uint top, uint bottom, uint left, uint right, uint spacer)
        {
            Top = top;
            Bottom = bottom;
            Left = left;
            Right = right;
            Spacer = spacer;
        }
        public uint Top
        {
            get;
            set;
        }
        public uint Bottom
        {
            get;
            set;
        }
        public uint Left
        {
            get;
            set;
        }
        public uint Right
        {
            get;
            set;
        }
        public uint Spacer
        {
            get;
            set;
        }
        public virtual void UpdateLayout(List<Component> componentList, Position origin, Size area){}
        public virtual Size GetPreferedSize() { return new Size(); }
    }
}
