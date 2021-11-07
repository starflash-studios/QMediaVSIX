// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceContextStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ResourceContext))]
  [Guid(550455596, 44815, 17675, 157, 166, 16, 109, 208, 194, 154, 57)]
  internal interface IResourceContextStatics3
  {
    [Overload("SetGlobalQualifierValueWithPersistence")]
    void SetGlobalQualifierValue(
      string key,
      string value,
      ResourceQualifierPersistence persistence);
  }
}
