﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyout2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MenuFlyout))]
  [Guid(1350335405, 55761, 19461, 157, 75, 205, 168, 222, 154, 178, 66)]
  [WebHostHidden]
  internal interface IMenuFlyout2
  {
    void ShowAt(UIElement targetElement, Point point);
  }
}