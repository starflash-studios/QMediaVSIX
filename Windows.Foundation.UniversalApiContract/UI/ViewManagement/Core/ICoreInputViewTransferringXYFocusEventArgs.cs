// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.ICoreInputViewTransferringXYFocusEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(81663647, 47618, 18512, 139, 85, 216, 45, 3, 186, 109, 127)]
  [ExclusiveTo(typeof (CoreInputViewTransferringXYFocusEventArgs))]
  internal interface ICoreInputViewTransferringXYFocusEventArgs
  {
    Rect Origin { get; }

    CoreInputViewXYFocusTransferDirection Direction { get; }

    bool TransferHandled { set; get; }

    bool KeepPrimaryViewVisible { set; get; }
  }
}
