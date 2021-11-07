// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppUriHandlerRegistrationManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppUriHandlerRegistrationManager))]
  [Guid(3185560305, 46362, 24169, 174, 253, 112, 136, 217, 242, 177, 35)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IAppUriHandlerRegistrationManager2
  {
    string PackageFamilyName { get; }
  }
}
