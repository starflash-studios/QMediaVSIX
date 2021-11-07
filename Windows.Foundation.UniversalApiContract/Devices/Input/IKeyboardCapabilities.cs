// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IKeyboardCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [Guid(977247062, 26520, 19388, 131, 62, 15, 52, 177, 124, 101, 255)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyboardCapabilities))]
  internal interface IKeyboardCapabilities
  {
    int KeyboardPresent { get; }
  }
}
