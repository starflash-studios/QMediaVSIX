// Decompiled with JetBrains decompiler
// Type: Windows.Media.ISystemMediaTransportControlsPropertyChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (SystemMediaTransportControlsPropertyChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3502901558, 13211, 19635, 142, 235, 115, 118, 7, 245, 110, 8)]
  internal interface ISystemMediaTransportControlsPropertyChangedEventArgs
  {
    SystemMediaTransportControlsProperty Property { get; }
  }
}
