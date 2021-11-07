// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreInputViewOcclusionsChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (CoreInputViewOcclusionsChangedEventArgs))]
  [Guid(3188729832, 46062, 19959, 149, 84, 137, 205, 198, 96, 130, 194)]
  internal interface ICoreInputViewOcclusionsChangedEventArgs
  {
    IVectorView<CoreInputViewOcclusion> Occlusions { get; }

    bool Handled { get; set; }
  }
}
