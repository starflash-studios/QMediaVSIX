// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IWindowingEnvironmentStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [ExclusiveTo(typeof (WindowingEnvironment))]
  [Guid(2270076855, 50754, 21931, 138, 162, 22, 47, 115, 74, 154, 114)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  internal interface IWindowingEnvironmentStatics
  {
    [Overload("FindAll")]
    IVectorView<WindowingEnvironment> FindAll();

    [Overload("FindAllWithKind")]
    IVectorView<WindowingEnvironment> FindAll(
      WindowingEnvironmentKind kind);
  }
}
