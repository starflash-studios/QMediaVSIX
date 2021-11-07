// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityAttributionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (UserActivityAttribution))]
  [Guid(3861631570, 50534, 20290, 153, 116, 145, 108, 77, 118, 55, 126)]
  internal interface IUserActivityAttributionFactory
  {
    UserActivityAttribution CreateWithUri(Uri iconUri);
  }
}
