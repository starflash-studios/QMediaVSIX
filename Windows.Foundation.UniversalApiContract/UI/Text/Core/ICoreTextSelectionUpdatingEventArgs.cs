// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextSelectionUpdatingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextSelectionUpdatingEventArgs))]
  [Guid(3561325471, 65151, 19413, 138, 38, 9, 34, 193, 179, 230, 57)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreTextSelectionUpdatingEventArgs
  {
    CoreTextRange Selection { get; }

    CoreTextSelectionUpdatingResult Result { get; set; }

    bool IsCanceled { get; }

    Deferral GetDeferral();
  }
}
