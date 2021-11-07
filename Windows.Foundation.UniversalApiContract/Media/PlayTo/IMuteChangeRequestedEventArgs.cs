// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IMuteChangeRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3837064694, 44831, 20254, 180, 55, 125, 163, 36, 0, 225, 212)]
  [ExclusiveTo(typeof (MuteChangeRequestedEventArgs))]
  internal interface IMuteChangeRequestedEventArgs
  {
    bool Mute { get; }
  }
}
