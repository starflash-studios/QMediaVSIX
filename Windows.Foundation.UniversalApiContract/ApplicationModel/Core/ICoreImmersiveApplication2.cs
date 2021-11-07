// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreImmersiveApplication2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [Guid(2190351926, 59875, 19708, 155, 102, 72, 183, 142, 169, 187, 44)]
  [ExclusiveTo(typeof (CoreApplication))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreImmersiveApplication2
  {
    [Overload("CreateNewViewFromMainView")]
    CoreApplicationView CreateNewView();
  }
}
