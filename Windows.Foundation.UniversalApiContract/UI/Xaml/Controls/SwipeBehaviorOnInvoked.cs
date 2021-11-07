// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SwipeBehaviorOnInvoked
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how a SwipeControl behaves after a command is invoked.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum SwipeBehaviorOnInvoked
  {
    /// <summary>In **Reveal** mode, the SwipeControl closes after an item is invoked. In **Execute** mode, the SwipeControl remains open.</summary>
    Auto,
    /// <summary>The SwipeControl closes after an item is invoked.</summary>
    Close,
    /// <summary>The SwipeControl remains open after an item is invoked.</summary>
    RemainOpen,
  }
}
