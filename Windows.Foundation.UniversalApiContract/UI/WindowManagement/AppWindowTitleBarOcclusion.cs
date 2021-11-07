// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowTitleBarOcclusion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Represents the system-reserved regions of the app window that will occlude app content if ExtendsContentIntoTitleBar is true.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class AppWindowTitleBarOcclusion : IAppWindowTitleBarOcclusion
  {
    /// <summary>Gets a rectangle that defines the width, height, and offset of the occlusion in app content visual relative coordinates.</summary>
    /// <returns>A rectangle that defines the width, height, and offset of the occlusion in app content visual relative coordinates.</returns>
    public extern Rect OccludingRect { [MethodImpl] get; }
  }
}
