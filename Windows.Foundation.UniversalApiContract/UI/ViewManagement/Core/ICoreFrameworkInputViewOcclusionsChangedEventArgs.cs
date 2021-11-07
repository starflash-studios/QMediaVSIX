// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreFrameworkInputViewOcclusionsChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (CoreFrameworkInputViewOcclusionsChangedEventArgs))]
  [Guid(4084156745, 51244, 21457, 167, 93, 43, 43, 175, 13, 155, 13)]
  internal interface ICoreFrameworkInputViewOcclusionsChangedEventArgs
  {
    IVectorView<CoreInputViewOcclusion> Occlusions { get; }

    bool Handled { get; }
  }
}
