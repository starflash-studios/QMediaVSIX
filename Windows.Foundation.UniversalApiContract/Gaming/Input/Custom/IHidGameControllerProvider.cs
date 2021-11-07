// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IHidGameControllerProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [Guid(2513320692, 44016, 19304, 160, 129, 59, 125, 231, 63, 240, 231)]
  [ExclusiveTo(typeof (HidGameControllerProvider))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IHidGameControllerProvider : IGameControllerProvider
  {
    ushort UsageId { get; }

    ushort UsagePage { get; }

    void GetFeatureReport(byte reportId, [Out] byte[] reportBuffer);

    void SendFeatureReport(byte reportId, byte[] reportBuffer);

    void SendOutputReport(byte reportId, byte[] reportBuffer);
  }
}
