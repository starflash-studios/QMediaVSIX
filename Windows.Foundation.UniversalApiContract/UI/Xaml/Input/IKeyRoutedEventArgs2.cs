// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IKeyRoutedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Input
{
  [Guid(453170554, 38452, 20244, 145, 178, 19, 62, 66, 253, 179, 205)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyRoutedEventArgs))]
  [WebHostHidden]
  internal interface IKeyRoutedEventArgs2
  {
    VirtualKey OriginalKey { get; }
  }
}
