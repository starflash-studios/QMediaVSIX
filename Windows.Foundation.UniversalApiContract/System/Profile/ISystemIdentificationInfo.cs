// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.ISystemIdentificationInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System.Profile
{
  [Guid(207986301, 50114, 19763, 162, 223, 33, 188, 65, 145, 110, 179)]
  [ExclusiveTo(typeof (SystemIdentificationInfo))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ISystemIdentificationInfo
  {
    IBuffer Id { get; }

    SystemIdentificationSource Source { get; }
  }
}
