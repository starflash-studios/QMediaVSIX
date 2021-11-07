// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemGPSProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3237244596, 49524, 18458, 188, 37, 146, 25, 134, 246, 166, 243)]
  [ExclusiveTo(typeof (SystemGPSProperties))]
  internal interface ISystemGPSProperties
  {
    string LatitudeDecimal { get; }

    string LongitudeDecimal { get; }
  }
}
