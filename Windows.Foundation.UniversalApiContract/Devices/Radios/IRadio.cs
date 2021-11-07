// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Radios.IRadio
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Radios
{
  [ExclusiveTo(typeof (Radio))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(622926047, 45886, 16746, 135, 95, 28, 243, 138, 226, 216, 62)]
  internal interface IRadio
  {
    [RemoteAsync]
    IAsyncOperation<RadioAccessStatus> SetStateAsync(
      RadioState value);

    event TypedEventHandler<Radio, object> StateChanged;

    RadioState State { get; }

    string Name { get; }

    RadioKind Kind { get; }
  }
}
