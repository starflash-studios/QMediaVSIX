// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.GameBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  /// <summary>Provides notifications and information about the visibility and input redirection state of Game bar.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGameBarStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public static class GameBar
  {
    /// <summary>Occurs when Game bar is shown or dismissed.</summary>
    public static extern event EventHandler<object> VisibilityChanged;

    /// <summary>Occurs when input is redirected to Game bar or input is restored to the game.</summary>
    public static extern event EventHandler<object> IsInputRedirectedChanged;

    /// <summary>Indicates whether Game bar is currently visible.</summary>
    /// <returns>**true** if Game bar is currently visible; **false** otherwise.</returns>
    public static extern bool Visible { [MethodImpl] get; }

    /// <summary>Indicates whether input is currently redirected to Game bar.</summary>
    /// <returns>**true** if input is currently redirected to Game bar; **false** otherwise.</returns>
    public static extern bool IsInputRedirected { [MethodImpl] get; }
  }
}
