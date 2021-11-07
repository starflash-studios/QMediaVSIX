// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextLayoutBounds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3916614004, 17462, 18711, 128, 208, 165, 37, 228, 202, 103, 128)]
  [ExclusiveTo(typeof (CoreTextLayoutBounds))]
  internal interface ICoreTextLayoutBounds
  {
    Rect TextBounds { get; set; }

    Rect ControlBounds { get; set; }
  }
}
