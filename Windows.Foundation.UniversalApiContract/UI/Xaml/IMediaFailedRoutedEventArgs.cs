﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IMediaFailedRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1188166285, 20809, 16723, 186, 60, 176, 62, 100, 238, 83, 30)]
  [ExclusiveTo(typeof (MediaFailedRoutedEventArgs))]
  internal interface IMediaFailedRoutedEventArgs
  {
    string ErrorTrace { get; }
  }
}