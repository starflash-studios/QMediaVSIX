// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ExclusiveTo(typeof (ResourceContext))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(799158091, 28798, 19239, 173, 13, 208, 216, 205, 70, 143, 210)]
  internal interface IResourceContext
  {
    IObservableMap<string, string> QualifierValues { get; }

    [Overload("Reset")]
    void Reset();

    [Overload("ResetQualifierValues")]
    void Reset(IIterable<string> qualifierNames);

    void OverrideToMatch(IIterable<ResourceQualifier> result);

    ResourceContext Clone();

    IVectorView<string> Languages { get; set; }
  }
}
