// Decompiled with JetBrains decompiler
// Type: Windows.UI.UIContentRoot
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI
{
  /// <summary>Represents the root of a UI element tree for an app window or view.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UIContentRoot : IUIContentRoot
  {
    /// <summary>Gets the context identifier for the content root.</summary>
    /// <returns>The context identifier for the content root.</returns>
    public extern UIContext UIContext { [MethodImpl] get; }
  }
}
