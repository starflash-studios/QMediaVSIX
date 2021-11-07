// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowPlacement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Represents info about the placement of an app window.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppWindowPlacement : IAppWindowPlacement
  {
    /// <summary>Gets the display region for the app window.</summary>
    /// <returns>The display region for the app window.</returns>
    public extern DisplayRegion DisplayRegion { [MethodImpl] get; }

    /// <summary>Gets the offset of the app window.</summary>
    /// <returns>The offset of the app window.</returns>
    public extern Point Offset { [MethodImpl] get; }

    /// <summary>Gets the size of the app window.</summary>
    /// <returns>The size of the app window.</returns>
    public extern Size Size { [MethodImpl] get; }
  }
}
