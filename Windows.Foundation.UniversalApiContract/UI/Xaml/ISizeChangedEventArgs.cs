﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ISizeChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3576770144, 23745, 17057, 146, 12, 26, 244, 107, 226, 249, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SizeChangedEventArgs))]
  internal interface ISizeChangedEventArgs
  {
    Size PreviousSize { get; }

    Size NewSize { get; }
  }
}