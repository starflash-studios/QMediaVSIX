// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputShortcut
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Specifies the system shortcuts for InjectShortcut.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum InjectedInputShortcut
  {
    /// <summary>Indicates traversal through a back stack.</summary>
    Back,
    /// <summary>Indicates traversal to a start, or home, screen.</summary>
    Start,
    /// <summary>Indicates traversal to a search screen.</summary>
    Search,
  }
}
