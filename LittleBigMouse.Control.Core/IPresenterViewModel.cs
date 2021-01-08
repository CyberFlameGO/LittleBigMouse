﻿/*
  LittleBigMouse.Control.Core
  Copyright (c) 2017 Mathieu GRENET.  All right reserved.

  This file is part of LittleBigMouse.Control.Core.

    LittleBigMouse.Control.Core is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LittleBigMouse.Control.Core is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MouseControl.  If not, see <http://www.gnu.org/licenses/>.

	  mailto:mathieu@mgth.fr
	  http://www.mgth.fr
*/

using System;
using System.ComponentModel;
using LittleBigMouse.Control.Main;

namespace LittleBigMouse.Control
{
    public interface IPresenterViewModel : INotifyPropertyChanged
    {
        MainViewModel MainViewModel { get; }
        Type ViewMode { get; set; }

        //private IPluginScreenControl _screenControlGetter;
        //public IPluginScreenControl ScreenControlGetter
        //{
        //    get => this.Get<IPluginScreenControl>(); set => this.Set(value);
        //}

        //double Ratio { get; }
        //double PhysicalToUiX(double x);
        //double PhysicalToUiY(double y);
    }
}
