﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (MenuBar))]
  [Guid(3371596556, 3702, 23282, 186, 222, 120, 80, 73, 200, 10, 65)]
  [WebHostHidden]
  internal interface IMenuBar
  {
    IVector<MenuBarItem> Items { get; }
  }
}