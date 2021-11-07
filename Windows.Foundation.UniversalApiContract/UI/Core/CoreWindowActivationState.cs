// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreWindowActivationState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Specifies the set of reasons that a CoreWindow 's Activated event was raised.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CoreWindowActivationState
  {
    /// <summary>The window was activated by a call to Activate.</summary>
    CodeActivated,
    /// <summary>The window was deactivated.</summary>
    Deactivated,
    /// <summary>The window was activated by pointer interaction.</summary>
    PointerActivated,
  }
}
