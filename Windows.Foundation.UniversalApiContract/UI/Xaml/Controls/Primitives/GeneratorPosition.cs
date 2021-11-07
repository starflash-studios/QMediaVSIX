// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.GeneratorPosition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>GeneratorPosition is used to describe the position of an item that is managed by ItemContainerGenerator.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct GeneratorPosition
  {
    /// <summary>The index that is relative to the generated (realized) items.</summary>
    public int Index;
    /// <summary>The offset that is relative to the ungenerated (unrealized) items near the indexed item.</summary>
    public int Offset;
  }
}
