// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreInputSourceBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Defines the base interface for an input source used by a CoreWindow.</summary>
  [Guid(2672330759, 17792, 19432, 190, 104, 146, 169, 49, 23, 19, 187)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface ICoreInputSourceBase
  {
    /// <summary>Gets the event dispatcher for the window.</summary>
    /// <returns>The event dispatcher for the window.</returns>
    CoreDispatcher Dispatcher { get; }

    /// <summary>Gets or sets a value that indicates whether input is enabled for the UWP app.</summary>
    /// <returns>True if input is enabled for the app; false if it is disabled.</returns>
    bool IsInputEnabled { get; set; }

    /// <summary>Occurs when input is enabled or disabled for the UWP app.</summary>
    event TypedEventHandler<object, InputEnabledEventArgs> InputEnabled;
  }
}
