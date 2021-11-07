// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreWindowEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Defines the set of arguments returned to an app after a window input or behavior event.</summary>
  [Guid(657137395, 50739, 19877, 162, 108, 198, 208, 245, 107, 41, 218)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICoreWindowEventArgs
  {
    /// <summary>Specifies the property that gets or sets whether the event was handled.</summary>
    /// <returns>True if the event has been handled by the appropriate delegate; false if it has not.</returns>
    bool Handled { get; set; }
  }
}
