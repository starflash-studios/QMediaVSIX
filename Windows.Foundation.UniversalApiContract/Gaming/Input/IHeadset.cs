// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IHeadset
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Headset))]
  [Guid(1070683887, 26917, 16296, 145, 129, 2, 156, 82, 35, 174, 59)]
  internal interface IHeadset
  {
    string CaptureDeviceId { get; }

    string RenderDeviceId { get; }
  }
}
