// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceContextStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [Guid(1106727663, 4783, 16825, 171, 54, 177, 235, 75, 81, 36, 96)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ResourceContext))]
  internal interface IResourceContextStatics2
  {
    ResourceContext GetForCurrentView();

    [Overload("SetGlobalQualifierValue")]
    void SetGlobalQualifierValue(string key, string value);

    [Overload("ResetGlobalQualifierValues")]
    void ResetGlobalQualifierValues();

    [Overload("ResetGlobalQualifierValuesForSpecifiedQualifiers")]
    void ResetGlobalQualifierValues(IIterable<string> qualifierNames);

    ResourceContext GetForViewIndependentUse();
  }
}
