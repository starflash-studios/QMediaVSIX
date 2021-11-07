// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreImmersiveApplication3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [Guid(882924335, 60941, 16869, 131, 20, 207, 16, 201, 27, 240, 175)]
  [ExclusiveTo(typeof (CoreApplication))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ICoreImmersiveApplication3
  {
    [Overload("CreateNewViewWithViewSource")]
    CoreApplicationView CreateNewView(IFrameworkViewSource viewSource);
  }
}
