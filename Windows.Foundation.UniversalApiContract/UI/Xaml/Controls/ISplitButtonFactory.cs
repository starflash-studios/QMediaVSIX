﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISplitButtonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SplitButton))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(838976303, 19797, 22685, 151, 221, 97, 127, 163, 100, 33, 55)]
  internal interface ISplitButtonFactory
  {
    SplitButton CreateInstance(object baseInterface, out object innerInterface);
  }
}