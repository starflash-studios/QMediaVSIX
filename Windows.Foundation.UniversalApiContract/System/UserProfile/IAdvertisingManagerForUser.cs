// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IAdvertisingManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (AdvertisingManagerForUser))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2458645456, 53116, 19120, 167, 220, 109, 197, 188, 212, 66, 82)]
  internal interface IAdvertisingManagerForUser
  {
    string AdvertisingId { get; }

    User User { get; }
  }
}
