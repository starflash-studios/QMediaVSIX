// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingDeviceSelectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [Guid(3695419014, 56663, 19725, 148, 0, 175, 69, 228, 251, 54, 99)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CastingDeviceSelectedEventArgs))]
  internal interface ICastingDeviceSelectedEventArgs
  {
    CastingDevice SelectedCastingDevice { get; }
  }
}
