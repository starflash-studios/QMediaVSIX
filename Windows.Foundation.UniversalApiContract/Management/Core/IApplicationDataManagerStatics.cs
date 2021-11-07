// Decompiled with JetBrains decompiler
// Type: Windows.Management.Core.IApplicationDataManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Management.Core
{
  [ExclusiveTo(typeof (ApplicationDataManager))]
  [Guid(504914659, 27022, 18849, 151, 82, 222, 233, 73, 37, 185, 179)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IApplicationDataManagerStatics
  {
    ApplicationData CreateForPackageFamily(string packageFamilyName);
  }
}
