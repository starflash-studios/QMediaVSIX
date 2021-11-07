// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1904866723, 13041, 18147, 190, 253, 68, 210, 102, 59, 126, 106)]
  [ExclusiveTo(typeof (HidCollection))]
  internal interface IHidCollection
  {
    uint Id { get; }

    HidCollectionType Type { get; }

    uint UsagePage { get; }

    uint UsageId { get; }
  }
}
