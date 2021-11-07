// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.ITouchCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ExclusiveTo(typeof (TouchCapabilities))]
  [Guid(551376377, 5105, 18120, 146, 133, 44, 5, 250, 62, 218, 111)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITouchCapabilities
  {
    int TouchPresent { get; }

    uint Contacts { get; }
  }
}
