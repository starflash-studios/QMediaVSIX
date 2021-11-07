// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkPresenterPredefinedConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Specifies the inking behavior of one or more contact points. Used with SetPredefinedConfiguration.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum InkPresenterPredefinedConfiguration
  {
    /// <summary>A single, primary contact point is used to draw an InkStroke.</summary>
    SimpleSinglePointer,
    /// <summary>Each contact point is used to draw an InkStroke. </summary>
    SimpleMultiplePointer,
  }
}
