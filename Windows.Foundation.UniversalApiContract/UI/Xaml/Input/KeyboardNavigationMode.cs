// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.KeyboardNavigationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Specifies the tabbing behavior across tab stops for a tabbing sequence within a container.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum KeyboardNavigationMode
  {
    /// <summary>Tab indexes are considered on the local subtree only inside this container.</summary>
    Local,
    /// <summary>Focus returns to the first or the last keyboard navigation stop inside of a container when the first or last keyboard navigation stop is reached.</summary>
    Cycle,
    /// <summary>The container and all of its child elements as a whole receive focus only once.</summary>
    Once,
  }
}
